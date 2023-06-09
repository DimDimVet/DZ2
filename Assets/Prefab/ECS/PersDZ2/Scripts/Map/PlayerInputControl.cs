//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Prefab/ECS/PersDZ2/Scripts/Map/PlayerInputControl.inputactions
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

public partial class @PlayerInputControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputControl"",
    ""maps"": [
        {
            ""name"": ""Map"",
            ""id"": ""b903836f-aaf8-4686-982f-fa2604373ecb"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""234175ce-b8c0-44c0-9b9a-408a645e768b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""03be7adb-44ce-4cfc-8194-4ec04f30e2c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pull"",
                    ""type"": ""Button"",
                    ""id"": ""5fec4a09-57bd-42fc-ab50-6e43a228f337"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6d2ec4b2-2eaa-4a46-8841-f02f6d2c4de9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1002138e-1a37-4a63-8e36-19cc17f940bc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""79cfaad0-5a5f-457c-b2c0-89d42275ebbc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""70406bba-2583-4967-be76-3ebfc8266e4a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9d0c8316-e52c-4e7f-83c8-058b0f2f4802"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d676cf1c-bc21-4037-bc21-8c49b5b9145c"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9c79aaf-2a61-4bb4-b361-5b9daf0b16d1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0d11b8c-b196-4d46-afdc-eb7f86019db1"",
                    ""path"": ""<Sensor>"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc648dc4-f3dc-49f3-878f-239532a7ac33"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UIMap"",
            ""id"": ""a0dd3480-a340-4901-81b4-7bdb94323267"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3ddf9990-e63c-4f26-8492-a65220125f7c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e80fcc03-0adb-4513-b8ba-72bd564c3b62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""07607265-86c1-4df1-a044-0ccf26b3da60"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""57a0f5b7-83f8-4fcc-89c1-448225777a76"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1489212b-235f-417b-9d5c-9d6ee7e1326c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b567fb58-7d70-4e82-991b-2f2dbf5dcaaf"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3f99bef7-8697-4398-9c61-41b36faaecb7"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7556f1a4-5016-4950-a745-dbf9076396ab"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ec1df658-099c-4e71-8b9e-795ddaf002b2"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""032edaee-9188-4922-b76e-cf8e90a6de25"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6fe37c90-3165-4c64-b80d-11e58cc4f201"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""edaebe42-44b5-46c0-98f2-d0664a64bc82"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c582a3be-3ff7-48cc-ae38-e7e0e76e2b33"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f7ff05d-08a6-4292-8f1b-8c94167cd707"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcfa5156-32f6-4e90-92ee-2ad9da343eed"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47089091-95b7-4cf8-888d-ab0a4bd9f45c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f022cc8a-5b6e-4fc3-b42d-9fed6a0d8b7e"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4eb5c28d-97b6-4b36-b47e-635b1982c882"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af878a36-850a-46b6-ae80-a9bc2e559790"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Map
        m_Map = asset.FindActionMap("Map", throwIfNotFound: true);
        m_Map_WASD = m_Map.FindAction("WASD", throwIfNotFound: true);
        m_Map_Shoot = m_Map.FindAction("Shoot", throwIfNotFound: true);
        m_Map_Pull = m_Map.FindAction("Pull", throwIfNotFound: true);
        // UIMap
        m_UIMap = asset.FindActionMap("UIMap", throwIfNotFound: true);
        m_UIMap_WASD = m_UIMap.FindAction("WASD", throwIfNotFound: true);
        m_UIMap_Click = m_UIMap.FindAction("Click", throwIfNotFound: true);
        m_UIMap_Point = m_UIMap.FindAction("Point", throwIfNotFound: true);
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

    // Map
    private readonly InputActionMap m_Map;
    private IMapActions m_MapActionsCallbackInterface;
    private readonly InputAction m_Map_WASD;
    private readonly InputAction m_Map_Shoot;
    private readonly InputAction m_Map_Pull;
    public struct MapActions
    {
        private @PlayerInputControl m_Wrapper;
        public MapActions(@PlayerInputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_Map_WASD;
        public InputAction @Shoot => m_Wrapper.m_Map_Shoot;
        public InputAction @Pull => m_Wrapper.m_Map_Pull;
        public InputActionMap Get() { return m_Wrapper.m_Map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MapActions set) { return set.Get(); }
        public void SetCallbacks(IMapActions instance)
        {
            if (m_Wrapper.m_MapActionsCallbackInterface != null)
            {
                @WASD.started -= m_Wrapper.m_MapActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_MapActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_MapActionsCallbackInterface.OnWASD;
                @Shoot.started -= m_Wrapper.m_MapActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MapActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MapActionsCallbackInterface.OnShoot;
                @Pull.started -= m_Wrapper.m_MapActionsCallbackInterface.OnPull;
                @Pull.performed -= m_Wrapper.m_MapActionsCallbackInterface.OnPull;
                @Pull.canceled -= m_Wrapper.m_MapActionsCallbackInterface.OnPull;
            }
            m_Wrapper.m_MapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Pull.started += instance.OnPull;
                @Pull.performed += instance.OnPull;
                @Pull.canceled += instance.OnPull;
            }
        }
    }
    public MapActions @Map => new MapActions(this);

    // UIMap
    private readonly InputActionMap m_UIMap;
    private IUIMapActions m_UIMapActionsCallbackInterface;
    private readonly InputAction m_UIMap_WASD;
    private readonly InputAction m_UIMap_Click;
    private readonly InputAction m_UIMap_Point;
    public struct UIMapActions
    {
        private @PlayerInputControl m_Wrapper;
        public UIMapActions(@PlayerInputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_UIMap_WASD;
        public InputAction @Click => m_Wrapper.m_UIMap_Click;
        public InputAction @Point => m_Wrapper.m_UIMap_Point;
        public InputActionMap Get() { return m_Wrapper.m_UIMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIMapActions set) { return set.Get(); }
        public void SetCallbacks(IUIMapActions instance)
        {
            if (m_Wrapper.m_UIMapActionsCallbackInterface != null)
            {
                @WASD.started -= m_Wrapper.m_UIMapActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_UIMapActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_UIMapActionsCallbackInterface.OnWASD;
                @Click.started -= m_Wrapper.m_UIMapActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIMapActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIMapActionsCallbackInterface.OnClick;
                @Point.started -= m_Wrapper.m_UIMapActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIMapActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIMapActionsCallbackInterface.OnPoint;
            }
            m_Wrapper.m_UIMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
            }
        }
    }
    public UIMapActions @UIMap => new UIMapActions(this);
    public interface IMapActions
    {
        void OnWASD(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPull(InputAction.CallbackContext context);
    }
    public interface IUIMapActions
    {
        void OnWASD(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
    }
}
