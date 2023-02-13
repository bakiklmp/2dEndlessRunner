//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""4339e764-3ac1-4543-a75b-f5c9c0eb4e85"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""71357f72-38b5-422c-bbf6-fe2670fb0421"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.15)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Backdash"",
                    ""type"": ""Button"",
                    ""id"": ""07e30c39-5842-44e1-8fd0-f0b38a787347"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e7764680-0f6b-4356-894d-5fda799dab19"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""534227b5-d57d-4baf-a8ab-06917350a909"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""3a300915-9c33-4d8f-899b-eddd40dc9c86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""2792a3c3-557d-4de1-bbe7-05f26fc97c45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""69119188-7714-496b-a11f-13c001b05e3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RunnerJump"",
                    ""type"": ""Button"",
                    ""id"": ""837e1e04-a473-4628-84a9-1a8e266c18b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=0.1)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8323c754-6357-474a-a924-9395069a0150"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""164fe3bf-180e-4923-9bb8-f9efdbae8edd"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Backdash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""af887150-7731-4b7c-a40d-6eb2de7dfd1f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""715169e8-daaa-44d6-aeb1-fb1a9fd36063"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7603db88-c395-4572-9717-9cc827fd8350"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""992ac57c-e60b-4917-babb-69b9488beb1a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a1f1ff6c-0a40-4203-a204-7e7a64c3096c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3c72e121-9f4d-4b6c-ad8b-f1498d836d5a"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34ba0898-a94a-4379-a708-45fd1e9c4dc9"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d61815c8-1447-4012-8add-5be99b322ab3"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aae6e048-a365-467e-a97f-bd317d3539c1"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43f498eb-b823-48a1-83d1-8320904374ee"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunnerJump"",
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
            ""devices"": []
        }
    ]
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Jump = m_Main.FindAction("Jump", throwIfNotFound: true);
        m_Main_Backdash = m_Main.FindAction("Backdash", throwIfNotFound: true);
        m_Main_Move = m_Main.FindAction("Move", throwIfNotFound: true);
        m_Main_Slide = m_Main.FindAction("Slide", throwIfNotFound: true);
        m_Main_Roll = m_Main.FindAction("Roll", throwIfNotFound: true);
        m_Main_Shoot = m_Main.FindAction("Shoot", throwIfNotFound: true);
        m_Main_Attack = m_Main.FindAction("Attack", throwIfNotFound: true);
        m_Main_RunnerJump = m_Main.FindAction("RunnerJump", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Jump;
    private readonly InputAction m_Main_Backdash;
    private readonly InputAction m_Main_Move;
    private readonly InputAction m_Main_Slide;
    private readonly InputAction m_Main_Roll;
    private readonly InputAction m_Main_Shoot;
    private readonly InputAction m_Main_Attack;
    private readonly InputAction m_Main_RunnerJump;
    public struct MainActions
    {
        private @Controls m_Wrapper;
        public MainActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Main_Jump;
        public InputAction @Backdash => m_Wrapper.m_Main_Backdash;
        public InputAction @Move => m_Wrapper.m_Main_Move;
        public InputAction @Slide => m_Wrapper.m_Main_Slide;
        public InputAction @Roll => m_Wrapper.m_Main_Roll;
        public InputAction @Shoot => m_Wrapper.m_Main_Shoot;
        public InputAction @Attack => m_Wrapper.m_Main_Attack;
        public InputAction @RunnerJump => m_Wrapper.m_Main_RunnerJump;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Backdash.started -= m_Wrapper.m_MainActionsCallbackInterface.OnBackdash;
                @Backdash.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnBackdash;
                @Backdash.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnBackdash;
                @Move.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                @Slide.started -= m_Wrapper.m_MainActionsCallbackInterface.OnSlide;
                @Slide.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnSlide;
                @Slide.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnSlide;
                @Roll.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRoll;
                @Shoot.started -= m_Wrapper.m_MainActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnShoot;
                @Attack.started -= m_Wrapper.m_MainActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnAttack;
                @RunnerJump.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRunnerJump;
                @RunnerJump.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRunnerJump;
                @RunnerJump.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRunnerJump;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Backdash.started += instance.OnBackdash;
                @Backdash.performed += instance.OnBackdash;
                @Backdash.canceled += instance.OnBackdash;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Slide.started += instance.OnSlide;
                @Slide.performed += instance.OnSlide;
                @Slide.canceled += instance.OnSlide;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @RunnerJump.started += instance.OnRunnerJump;
                @RunnerJump.performed += instance.OnRunnerJump;
                @RunnerJump.canceled += instance.OnRunnerJump;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IMainActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnBackdash(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnRunnerJump(InputAction.CallbackContext context);
    }
}
