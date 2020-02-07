// GENERATED AUTOMATICALLY FROM 'Assets/KeyboardControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @KeyboardControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @KeyboardControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""KeyboardControls"",
    ""maps"": [
        {
            ""name"": ""KeyBoard Controls"",
            ""id"": ""d2a0f9f9-2883-49dc-a32c-e7d4d282e95a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1adf179c-3579-48a0-9f3f-f78306b6eec7"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackFlip1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f1554c70-71ee-491a-9b23-7396476459ee"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightRoll1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""70dad09b-9410-45ec-a620-844d5576e9e5"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftRoll1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""732998c9-142d-493f-8ba3-958ac54ca753"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FrontFlip1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c2591483-18fe-47bd-92be-e120b72f4ec8"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FrontSpin"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ba7b98fa-5aa8-416d-a0c1-b28331056b4a"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftSpin"",
                    ""type"": ""PassThrough"",
                    ""id"": ""329243d5-5c0c-4425-8414-c2b8371ae06e"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightSpin"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3465b547-20fe-4917-a40c-a57330f1fd36"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackSpin"",
                    ""type"": ""PassThrough"",
                    ""id"": ""319f83fc-50c8-4729-b008-dceb6e31f982"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8f0a123c-dc3f-4137-b1a2-abff3afe3781"",
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
                    ""id"": ""f0474312-b3f3-453e-a0ba-dc1fa06fef62"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3858081c-3994-47d8-b3b1-ccdf125b4c3e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""254cb0ba-b21b-49e5-aee7-dd6038d0d713"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""06f39225-51d7-4a3e-ab40-3ae9236700c8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift+W"",
                    ""id"": ""bf1fd13b-b258-4f0e-8d40-f572b12a508b"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontSpin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""4b1b8fed-9fe5-4c73-830f-66ab2e59da60"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""6002b8e7-b3dc-4d52-a5d0-3a8f18074ca7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift+A"",
                    ""id"": ""9b8ac19d-d153-4780-9603-088f89711975"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftSpin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""785fde05-9800-439c-a844-c7f98bedee5e"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""a473503d-b476-441a-b3e6-79535fe788eb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift + D"",
                    ""id"": ""cd5be334-c835-467f-b1aa-1764698dfff3"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightSpin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""25d2d7b9-d8ea-47f6-b6bc-2a01c9930c30"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""c4e86350-3e01-486e-a404-ba8d876dc32d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift+S"",
                    ""id"": ""a8ee4fe8-e9c6-4d73-b4d2-38a09ff2468f"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackSpin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""7901337f-89da-4d3e-b1db-63a9d1c20b4a"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""6f21eeb3-acb8-4c07-bca0-389e28edda1e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift+W"",
                    ""id"": ""5165f086-ba52-4009-b17b-0f3b75da070c"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FrontFlip1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""6f9c6f66-f6db-4957-80d2-9c8fc9721856"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FrontFlip1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""64aebac1-be79-45f6-a2fb-7001942eaf55"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FrontFlip1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift+A"",
                    ""id"": ""b8b861e2-3a60-4dde-8953-f0af190c31d6"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftRoll1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""95eff354-674d-4dce-aa7b-ec4b5f4a4379"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftRoll1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""c28e8857-813e-4df1-9b76-fced9674bdfb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftRoll1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift + D"",
                    ""id"": ""db560640-a930-4782-8230-131d348a9184"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightRoll1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""bfc9dc51-99a3-4897-8a6c-7107e81aa02c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightRoll1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""2a51b0fd-9031-4173-bf83-323bede44b8e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightRoll1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift+S"",
                    ""id"": ""0d55de30-67f3-454e-b0e3-ea5dbc3853dc"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BackFlip1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""56708e96-8830-4846-93d7-a6f2b980b863"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BackFlip1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""ef23a326-d79c-4462-90e9-e4a4993cef06"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BackFlip1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        }
    ]
}");
        // KeyBoard Controls
        m_KeyBoardControls = asset.FindActionMap("KeyBoard Controls", throwIfNotFound: true);
        m_KeyBoardControls_Movement = m_KeyBoardControls.FindAction("Movement", throwIfNotFound: true);
        m_KeyBoardControls_BackFlip1 = m_KeyBoardControls.FindAction("BackFlip1", throwIfNotFound: true);
        m_KeyBoardControls_RightRoll1 = m_KeyBoardControls.FindAction("RightRoll1", throwIfNotFound: true);
        m_KeyBoardControls_LeftRoll1 = m_KeyBoardControls.FindAction("LeftRoll1", throwIfNotFound: true);
        m_KeyBoardControls_FrontFlip1 = m_KeyBoardControls.FindAction("FrontFlip1", throwIfNotFound: true);
        m_KeyBoardControls_FrontSpin = m_KeyBoardControls.FindAction("FrontSpin", throwIfNotFound: true);
        m_KeyBoardControls_LeftSpin = m_KeyBoardControls.FindAction("LeftSpin", throwIfNotFound: true);
        m_KeyBoardControls_RightSpin = m_KeyBoardControls.FindAction("RightSpin", throwIfNotFound: true);
        m_KeyBoardControls_BackSpin = m_KeyBoardControls.FindAction("BackSpin", throwIfNotFound: true);
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

    // KeyBoard Controls
    private readonly InputActionMap m_KeyBoardControls;
    private IKeyBoardControlsActions m_KeyBoardControlsActionsCallbackInterface;
    private readonly InputAction m_KeyBoardControls_Movement;
    private readonly InputAction m_KeyBoardControls_BackFlip1;
    private readonly InputAction m_KeyBoardControls_RightRoll1;
    private readonly InputAction m_KeyBoardControls_LeftRoll1;
    private readonly InputAction m_KeyBoardControls_FrontFlip1;
    private readonly InputAction m_KeyBoardControls_FrontSpin;
    private readonly InputAction m_KeyBoardControls_LeftSpin;
    private readonly InputAction m_KeyBoardControls_RightSpin;
    private readonly InputAction m_KeyBoardControls_BackSpin;
    public struct KeyBoardControlsActions
    {
        private @KeyboardControls m_Wrapper;
        public KeyBoardControlsActions(@KeyboardControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_KeyBoardControls_Movement;
        public InputAction @BackFlip1 => m_Wrapper.m_KeyBoardControls_BackFlip1;
        public InputAction @RightRoll1 => m_Wrapper.m_KeyBoardControls_RightRoll1;
        public InputAction @LeftRoll1 => m_Wrapper.m_KeyBoardControls_LeftRoll1;
        public InputAction @FrontFlip1 => m_Wrapper.m_KeyBoardControls_FrontFlip1;
        public InputAction @FrontSpin => m_Wrapper.m_KeyBoardControls_FrontSpin;
        public InputAction @LeftSpin => m_Wrapper.m_KeyBoardControls_LeftSpin;
        public InputAction @RightSpin => m_Wrapper.m_KeyBoardControls_RightSpin;
        public InputAction @BackSpin => m_Wrapper.m_KeyBoardControls_BackSpin;
        public InputActionMap Get() { return m_Wrapper.m_KeyBoardControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyBoardControlsActions set) { return set.Get(); }
        public void SetCallbacks(IKeyBoardControlsActions instance)
        {
            if (m_Wrapper.m_KeyBoardControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnMovement;
                @BackFlip1.started -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnBackFlip1;
                @BackFlip1.performed -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnBackFlip1;
                @BackFlip1.canceled -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnBackFlip1;
                @RightRoll1.started -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnRightRoll1;
                @RightRoll1.performed -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnRightRoll1;
                @RightRoll1.canceled -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnRightRoll1;
                @LeftRoll1.started -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnLeftRoll1;
                @LeftRoll1.performed -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnLeftRoll1;
                @LeftRoll1.canceled -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnLeftRoll1;
                @FrontFlip1.started -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnFrontFlip1;
                @FrontFlip1.performed -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnFrontFlip1;
                @FrontFlip1.canceled -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnFrontFlip1;
                @FrontSpin.started -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnFrontSpin;
                @FrontSpin.performed -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnFrontSpin;
                @FrontSpin.canceled -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnFrontSpin;
                @LeftSpin.started -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnLeftSpin;
                @LeftSpin.performed -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnLeftSpin;
                @LeftSpin.canceled -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnLeftSpin;
                @RightSpin.started -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnRightSpin;
                @RightSpin.performed -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnRightSpin;
                @RightSpin.canceled -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnRightSpin;
                @BackSpin.started -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnBackSpin;
                @BackSpin.performed -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnBackSpin;
                @BackSpin.canceled -= m_Wrapper.m_KeyBoardControlsActionsCallbackInterface.OnBackSpin;
            }
            m_Wrapper.m_KeyBoardControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @BackFlip1.started += instance.OnBackFlip1;
                @BackFlip1.performed += instance.OnBackFlip1;
                @BackFlip1.canceled += instance.OnBackFlip1;
                @RightRoll1.started += instance.OnRightRoll1;
                @RightRoll1.performed += instance.OnRightRoll1;
                @RightRoll1.canceled += instance.OnRightRoll1;
                @LeftRoll1.started += instance.OnLeftRoll1;
                @LeftRoll1.performed += instance.OnLeftRoll1;
                @LeftRoll1.canceled += instance.OnLeftRoll1;
                @FrontFlip1.started += instance.OnFrontFlip1;
                @FrontFlip1.performed += instance.OnFrontFlip1;
                @FrontFlip1.canceled += instance.OnFrontFlip1;
                @FrontSpin.started += instance.OnFrontSpin;
                @FrontSpin.performed += instance.OnFrontSpin;
                @FrontSpin.canceled += instance.OnFrontSpin;
                @LeftSpin.started += instance.OnLeftSpin;
                @LeftSpin.performed += instance.OnLeftSpin;
                @LeftSpin.canceled += instance.OnLeftSpin;
                @RightSpin.started += instance.OnRightSpin;
                @RightSpin.performed += instance.OnRightSpin;
                @RightSpin.canceled += instance.OnRightSpin;
                @BackSpin.started += instance.OnBackSpin;
                @BackSpin.performed += instance.OnBackSpin;
                @BackSpin.canceled += instance.OnBackSpin;
            }
        }
    }
    public KeyBoardControlsActions @KeyBoardControls => new KeyBoardControlsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IKeyBoardControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnBackFlip1(InputAction.CallbackContext context);
        void OnRightRoll1(InputAction.CallbackContext context);
        void OnLeftRoll1(InputAction.CallbackContext context);
        void OnFrontFlip1(InputAction.CallbackContext context);
        void OnFrontSpin(InputAction.CallbackContext context);
        void OnLeftSpin(InputAction.CallbackContext context);
        void OnRightSpin(InputAction.CallbackContext context);
        void OnBackSpin(InputAction.CallbackContext context);
    }
}
