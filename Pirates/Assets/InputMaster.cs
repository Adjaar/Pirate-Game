// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""afa520ce-a308-4e26-9b38-fcdc823fd5bb"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3a53a52e-86ec-40af-97d1-b64228df1d4f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Cannons"",
                    ""type"": ""Button"",
                    ""id"": ""7e2b571d-ed79-45be-8d20-839f71d83c30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""6cb5c2a8-ede2-4bf1-9235-fa2bdc2d5725"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""ec433739-8c02-4d76-85c3-524c1640601c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Powerup"",
                    ""type"": ""Button"",
                    ""id"": ""7be5a31c-dd19-4688-a907-b4957c8fd210"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ef820bff-4ae7-4e8f-b4cb-32fa7b1caf3e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""92148724-d904-4c2d-bcfa-8cc4b244e609"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c5faa769-1d21-4487-abff-a8858218d515"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""977f4cb0-d0ff-457a-9129-3cbc932135e5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3806a41a-74f9-47ff-87de-7c09a62c5d1b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Port and Starboard"",
                    ""id"": ""ff4fc950-9013-47f7-b7c4-4962735cdf9b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannons"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d5ad9579-477d-43fa-9dc1-35212096cb21"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d096a4e2-ef46-4090-ba91-0a2b32cd4a88"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""12c591b0-6cd0-4f7d-8ccc-6180e85c3563"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""743ead71-4545-4945-8891-2653fb35897b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""196c0871-a31d-4e30-aec9-c2e93569e45a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Powerup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""a7e699ec-f213-42eb-9fcc-8e4caee9be5c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""071ff3fb-1b01-40aa-a5b7-506a81610e3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cannons"",
                    ""type"": ""Button"",
                    ""id"": ""cab5c8af-bc77-44d6-8902-1b4917b94331"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""9fbdbfb4-c354-4ad4-bdbb-3f8f19021bfd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Powerup"",
                    ""type"": ""Button"",
                    ""id"": ""48e4801a-0b29-48e1-94ea-dc69c477cd7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Xbox"",
                    ""id"": ""a8cdbc5a-752e-4b9b-b8a1-88da27b3c89a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b18fcf2c-c252-48c5-afb5-57d3345cd7be"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7c31c5e0-587d-48c9-ab53-e4a8151a7ac8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fe183dd0-a01e-4c3e-bfe5-d1eb3d20d20e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""371fba9b-45ea-4585-8591-5f632d9f13b6"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Other controller bindings"",
                    ""id"": ""14b04938-3e87-4c47-a803-b56572465347"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3f0dd979-2678-4747-87d2-3f4fb5b431c7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""409d71d7-0920-47f3-ab92-e09dd7d1a448"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""55d54352-8796-4aed-94fe-0bfd36a07142"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0a565292-ec7f-4b9f-97f1-2c813674667a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Port and Starboard"",
                    ""id"": ""983d72ed-0253-4fa4-b4ce-8900571a98b1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannons"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ec670654-62c8-4717-ac4f-bc65d6168ca2"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c2baa74b-62a7-4ac9-a63d-ad26fe0912ac"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Port and Starboard other controller"",
                    ""id"": ""c7dff12a-112b-44af-8854-2ed76437139d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannons"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ccd37abb-6706-41da-87ea-8b77ea150660"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4702aa01-7a2f-4133-b6d1-5f76675f03c3"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cannons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""31a7079a-a97f-45c4-8115-98688fb7f6a4"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffe1405d-5932-4225-96e8-3cbc1c85eb51"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d650d918-aad3-40de-b2bd-ed525e66eb24"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Powerup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0b20638-2fc0-43be-a00c-e20c29d8607a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Powerup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox Controller"",
            ""bindingGroup"": ""Xbox Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Cannons = m_Player.FindAction("Cannons", throwIfNotFound: true);
        m_Player_Escape = m_Player.FindAction("Escape", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Powerup = m_Player.FindAction("Powerup", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Movement = m_Player2.FindAction("Movement", throwIfNotFound: true);
        m_Player2_Cannons = m_Player2.FindAction("Cannons", throwIfNotFound: true);
        m_Player2_Interact = m_Player2.FindAction("Interact", throwIfNotFound: true);
        m_Player2_Powerup = m_Player2.FindAction("Powerup", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Cannons;
    private readonly InputAction m_Player_Escape;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Powerup;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Cannons => m_Wrapper.m_Player_Cannons;
        public InputAction @Escape => m_Wrapper.m_Player_Escape;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Powerup => m_Wrapper.m_Player_Powerup;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Cannons.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCannons;
                @Cannons.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCannons;
                @Cannons.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCannons;
                @Escape.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Powerup.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPowerup;
                @Powerup.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPowerup;
                @Powerup.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPowerup;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Cannons.started += instance.OnCannons;
                @Cannons.performed += instance.OnCannons;
                @Cannons.canceled += instance.OnCannons;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Powerup.started += instance.OnPowerup;
                @Powerup.performed += instance.OnPowerup;
                @Powerup.canceled += instance.OnPowerup;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Movement;
    private readonly InputAction m_Player2_Cannons;
    private readonly InputAction m_Player2_Interact;
    private readonly InputAction m_Player2_Powerup;
    public struct Player2Actions
    {
        private @InputMaster m_Wrapper;
        public Player2Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player2_Movement;
        public InputAction @Cannons => m_Wrapper.m_Player2_Cannons;
        public InputAction @Interact => m_Wrapper.m_Player2_Interact;
        public InputAction @Powerup => m_Wrapper.m_Player2_Powerup;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                @Cannons.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnCannons;
                @Cannons.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnCannons;
                @Cannons.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnCannons;
                @Interact.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnInteract;
                @Powerup.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPowerup;
                @Powerup.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPowerup;
                @Powerup.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPowerup;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Cannons.started += instance.OnCannons;
                @Cannons.performed += instance.OnCannons;
                @Cannons.canceled += instance.OnCannons;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Powerup.started += instance.OnPowerup;
                @Powerup.performed += instance.OnPowerup;
                @Powerup.canceled += instance.OnPowerup;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_XboxControllerSchemeIndex = -1;
    public InputControlScheme XboxControllerScheme
    {
        get
        {
            if (m_XboxControllerSchemeIndex == -1) m_XboxControllerSchemeIndex = asset.FindControlSchemeIndex("Xbox Controller");
            return asset.controlSchemes[m_XboxControllerSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCannons(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnPowerup(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCannons(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnPowerup(InputAction.CallbackContext context);
    }
}
