// GENERATED AUTOMATICALLY FROM 'Assets/GamePadControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GamePadControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GamePadControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GamePadControls"",
    ""maps"": [
        {
            ""name"": ""KeyBoard COntrols"",
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
                    ""name"": ""FrontFlip"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ba7b98fa-5aa8-416d-a0c1-b28331056b4a"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftRoll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""329243d5-5c0c-4425-8414-c2b8371ae06e"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightRoll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3465b547-20fe-4917-a40c-a57330f1fd36"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackFlip"",
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
                    ""action"": ""FrontFlip"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""4b1b8fed-9fe5-4c73-830f-66ab2e59da60"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontFlip"",
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
                    ""action"": ""FrontFlip"",
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
                    ""action"": ""LeftRoll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""785fde05-9800-439c-a844-c7f98bedee5e"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRoll"",
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
                    ""action"": ""LeftRoll"",
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
                    ""action"": ""RightRoll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""25d2d7b9-d8ea-47f6-b6bc-2a01c9930c30"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightRoll"",
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
                    ""action"": ""RightRoll"",
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
                    ""action"": ""BackFlip"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""7901337f-89da-4d3e-b1db-63a9d1c20b4a"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackFlip"",
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
                    ""action"": ""BackFlip"",
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
        // KeyBoard COntrols
        m_KeyBoardCOntrols = asset.FindActionMap("KeyBoard COntrols", throwIfNotFound: true);
        m_KeyBoardCOntrols_Movement = m_KeyBoardCOntrols.FindAction("Movement", throwIfNotFound: true);
        m_KeyBoardCOntrols_FrontFlip = m_KeyBoardCOntrols.FindAction("FrontFlip", throwIfNotFound: true);
        m_KeyBoardCOntrols_LeftRoll = m_KeyBoardCOntrols.FindAction("LeftRoll", throwIfNotFound: true);
        m_KeyBoardCOntrols_RightRoll = m_KeyBoardCOntrols.FindAction("RightRoll", throwIfNotFound: true);
        m_KeyBoardCOntrols_BackFlip = m_KeyBoardCOntrols.FindAction("BackFlip", throwIfNotFound: true);
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

    // KeyBoard COntrols
    private readonly InputActionMap m_KeyBoardCOntrols;
    private IKeyBoardCOntrolsActions m_KeyBoardCOntrolsActionsCallbackInterface;
    private readonly InputAction m_KeyBoardCOntrols_Movement;
    private readonly InputAction m_KeyBoardCOntrols_FrontFlip;
    private readonly InputAction m_KeyBoardCOntrols_LeftRoll;
    private readonly InputAction m_KeyBoardCOntrols_RightRoll;
    private readonly InputAction m_KeyBoardCOntrols_BackFlip;
    public struct KeyBoardCOntrolsActions
    {
        private @GamePadControls m_Wrapper;
        public KeyBoardCOntrolsActions(@GamePadControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_KeyBoardCOntrols_Movement;
        public InputAction @FrontFlip => m_Wrapper.m_KeyBoardCOntrols_FrontFlip;
        public InputAction @LeftRoll => m_Wrapper.m_KeyBoardCOntrols_LeftRoll;
        public InputAction @RightRoll => m_Wrapper.m_KeyBoardCOntrols_RightRoll;
        public InputAction @BackFlip => m_Wrapper.m_KeyBoardCOntrols_BackFlip;
        public InputActionMap Get() { return m_Wrapper.m_KeyBoardCOntrols; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyBoardCOntrolsActions set) { return set.Get(); }
        public void SetCallbacks(IKeyBoardCOntrolsActions instance)
        {
            if (m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnMovement;
                @FrontFlip.started -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnFrontFlip;
                @FrontFlip.performed -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnFrontFlip;
                @FrontFlip.canceled -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnFrontFlip;
                @LeftRoll.started -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnLeftRoll;
                @LeftRoll.performed -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnLeftRoll;
                @LeftRoll.canceled -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnLeftRoll;
                @RightRoll.started -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnRightRoll;
                @RightRoll.performed -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnRightRoll;
                @RightRoll.canceled -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnRightRoll;
                @BackFlip.started -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnBackFlip;
                @BackFlip.performed -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnBackFlip;
                @BackFlip.canceled -= m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface.OnBackFlip;
            }
            m_Wrapper.m_KeyBoardCOntrolsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @FrontFlip.started += instance.OnFrontFlip;
                @FrontFlip.performed += instance.OnFrontFlip;
                @FrontFlip.canceled += instance.OnFrontFlip;
                @LeftRoll.started += instance.OnLeftRoll;
                @LeftRoll.performed += instance.OnLeftRoll;
                @LeftRoll.canceled += instance.OnLeftRoll;
                @RightRoll.started += instance.OnRightRoll;
                @RightRoll.performed += instance.OnRightRoll;
                @RightRoll.canceled += instance.OnRightRoll;
                @BackFlip.started += instance.OnBackFlip;
                @BackFlip.performed += instance.OnBackFlip;
                @BackFlip.canceled += instance.OnBackFlip;
            }
        }
    }
    public KeyBoardCOntrolsActions @KeyBoardCOntrols => new KeyBoardCOntrolsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IKeyBoardCOntrolsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnFrontFlip(InputAction.CallbackContext context);
        void OnLeftRoll(InputAction.CallbackContext context);
        void OnRightRoll(InputAction.CallbackContext context);
        void OnBackFlip(InputAction.CallbackContext context);
    }
}
