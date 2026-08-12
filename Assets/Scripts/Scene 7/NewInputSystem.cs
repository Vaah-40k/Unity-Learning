using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystem : MonoBehaviour
{
    private PlayerInputActions input;

    private float speed = 5f;
    private Vector2 move;

    private void Awake()
    {
        input = new PlayerInputActions();

        LoadBindings();
    }

    private void OnEnable()
    {
        input.Player.Jump.performed += Jump;
        input.Player.Attack.performed += Attack;
        input.Player.Interact.performed += Interact;
        input.Player.OpenMenu.performed += OpenMenu;

        input.UI.CloseMenu.performed += CloseMenu;
        input.UI.Rebild.performed += StartRebind;

        EnablePlayer();
    }

    private void OnDisable()
    {
        input.Player.Jump.performed -= Jump;
        input.Player.Attack.performed -= Attack;
        input.Player.Interact.performed -= Interact;
        input.Player.OpenMenu.performed -= OpenMenu;
        input.UI.CloseMenu.performed -= CloseMenu;
        input.UI.Rebild.performed -= StartRebind;

        input.Player.Disable();
        input.UI.Disable();
    }

    private void Update()
    {
        UpdateMove();
        MenuNavigation();
    }

    private void EnablePlayer()
    {
        input.UI.Disable();
        input.Player.Enable();
    }

    private void DisablePlayer()
    {
        input.Player.Disable();

        move = Vector2.zero;
    }

    private void UpdateMove()
    {
        move = input.Player.Move.ReadValue<Vector2>();

        Vector3 movePlayer = new Vector3(move.x, 0f, move.y);

        if (input.Player.Sprint.IsPressed())
        {
            speed = 10f;
        }
        else
        {
            speed = 5f;
        }

        transform.position += movePlayer * speed * Time.deltaTime;
    }

    private void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("Прыжок");
    }

    private void Attack(InputAction.CallbackContext context)
    {
        Debug.Log("Игрок атакует мечом");
    }

    private void Interact(InputAction.CallbackContext context)
    {
        Debug.Log("Взаимодействие");
    }

    private void OpenMenu(InputAction.CallbackContext context)
    {
        Debug.Log("Открываем меню");

        DisablePlayer();
        EnableUI();
    }

    private void CloseMenu(InputAction.CallbackContext context)
    {
        Debug.Log("Закрываем меню");

        DisableUI();
        EnablePlayer();
    }

    private void EnableUI()
    {
        input.Player.Disable();
        input.UI.Enable();
    }

    private void DisableUI()
    {
        input.UI.Disable();
    }

    private void MenuNavigation()
    {
        Vector2 navigation = input.UI.MoveInventory.ReadValue<Vector2>();

        if (navigation.x > 0)
        {
            Debug.Log("Листаем меню вправо");
        }
        else if (navigation.x < 0)
        {
            Debug.Log("Листаем меню влево");
        }
        else if (navigation.y > 0)
        {
            Debug.Log("Листаем меню вверх");
        }
        else if (navigation.y < 0)
        {
            Debug.Log("Листаем меню вниз");
        }
    }

    private void StartRebind(InputAction.CallbackContext context)
    {
        RebindAction(input.Player.Jump, "Прыжок");
    }

    private void RebindAction(InputAction action, string actionName)
    {
        Debug.Log($"Нажмите новую клавишу для: {actionName}");

        input.Player.Disable();

        action
            .PerformInteractiveRebinding()
            .OnComplete(operation =>
            {
                operation.Dispose();

                input.Player.Enable();

                string binding = action.GetBindingDisplayString(0);

                Debug.Log($"{actionName} переназначен на: {binding}");

                SaveBindings();
            })
            .Start();
    }

    private void SaveBindings()
    {
        string json = input.asset.SaveBindingOverridesAsJson();

        PlayerPrefs.SetString("bindings", json);

        PlayerPrefs.Save();
    }

    private void LoadBindings()
    {
        string json = PlayerPrefs.GetString("bindings");

        input.asset.LoadBindingOverridesFromJson(json);
    }
}
