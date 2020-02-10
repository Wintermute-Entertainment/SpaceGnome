// GENERATED AUTOMATICALLY FROM 'Assets/PS4Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PS4PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PS4PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PS4Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d2a0f9f9-2883-49dc-a32c-e7d4d282e95a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1adf179c-3579-48a0-9f3f-f78306b6eec7"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackFlip"",
                    ""type"": ""Button"",
                    ""id"": ""f1554c70-71ee-491a-9b23-7396476459ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightRoll"",
                    ""type"": ""Button"",
                    ""id"": ""70dad09b-9410-45ec-a620-844d5576e9e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftRoll"",
                    ""type"": ""Button"",
                    ""id"": ""732998c9-142d-493f-8ba3-958ac54ca753"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartFlip"",
                    ""type"": ""Button"",
                    ""id"": ""c2591483-18fe-47bd-92be-e120b72f4ec8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FrontSpin"",
                    ""type"": ""Button"",
                    ""id"": ""ba7b98fa-5aa8-416d-a0c1-b28331056b4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftSpin"",
                    ""type"": ""Button"",
                    ""id"": ""329243d5-5c0c-4425-8414-c2b8371ae06e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightSpin"",
                    ""type"": ""Button"",
                    ""id"": ""3465b547-20fe-4917-a40c-a57330f1fd36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackSpin"",
                    ""type"": ""Button"",
                    ""id"": ""319f83fc-50c8-4729-b008-dceb6e31f982"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FloatUp"",
                    ""type"": ""Button"",
                    ""id"": ""93bd36f6-7082-4660-a075-3e8156de8805"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FloatDown"",
                    ""type"": ""Button"",
                    ""id"": ""00dd3188-6686-4634-94e9-1796c4794445"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NoseDive"",
                    ""type"": ""Button"",
                    ""id"": ""fdb65196-05ae-41ae-b9ed-50d4a1cf0909"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""UpDownLeftRIght"",
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
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3858081c-3994-47d8-b3b1-ccdf125b4c3e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""254cb0ba-b21b-49e5-aee7-dd6038d0d713"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""06f39225-51d7-4a3e-ab40-3ae9236700c8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""Movement"",
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
                    ""action"": ""StartFlip"",
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
                    ""action"": ""StartFlip"",
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
                    ""action"": ""StartFlip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""76be5618-34e4-411d-9eb0-5583fad53850"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartFlip"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""d7a47c5d-82a5-4b77-8216-896bb6b1ed29"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""StartFlip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""83209cef-0279-44fb-984c-e6b610141df3"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""StartFlip"",
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
                    ""action"": ""LeftRoll"",
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
                    ""action"": ""LeftRoll"",
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
                    ""action"": ""LeftRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""d4479b24-5638-4678-9380-f08531b91a26"",
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
                    ""id"": ""06a3b6d5-4fbf-4ae2-8420-2e6b8edd52ee"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""LeftRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""d960a020-9cc6-433f-8fda-f4864d48e5f8"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""LeftRoll"",
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
                    ""action"": ""RightRoll"",
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
                    ""action"": ""RightRoll"",
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
                    ""action"": ""RightRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""9378190b-a79d-4fb3-9c99-8c49cb955534"",
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
                    ""id"": ""c378aeb3-cb6f-4c0b-b590-f023e1eb7657"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""RightRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""08e1148d-15c5-4eb6-b890-2450c1fdc33f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""RightRoll"",
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
                    ""action"": ""BackFlip"",
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
                    ""action"": ""BackFlip"",
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
                    ""action"": ""BackFlip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""d578f394-2e62-4227-9fa6-73e4f7e914ed"",
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
                    ""id"": ""573a6428-4bfb-4902-b235-1d14e8f134de"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""BackFlip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""166b1f09-17be-45f5-bab2-3720fc67d8eb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""BackFlip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0166dd7f-a281-4dcb-a167-589ae2ebda00"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""FloatDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a567d276-9276-4bb5-8172-c4688fa5f2a4"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""NoseDive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With Two Modifiers"",
                    ""id"": ""468bc312-9260-424f-ba0e-94aad61fad16"",
                    ""path"": ""ButtonWithTwoModifiers"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontSpin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier1"",
                    ""id"": ""5c6cfd31-f53f-448e-8a0a-fe3ff95c5f38"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""FrontSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""modifier2"",
                    ""id"": ""a044ef14-2fe2-4fe8-846b-994dbc22f448"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""FrontSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""4d7c95f9-fb95-4538-9a90-285f4f728b95"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""FrontSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With Two Modifiers"",
                    ""id"": ""774ce74c-7298-4232-87ae-9c672e99cf0d"",
                    ""path"": ""ButtonWithTwoModifiers"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftSpin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier1"",
                    ""id"": ""83650cad-6360-423f-9e16-a98bcbcee6f6"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""LeftSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""modifier2"",
                    ""id"": ""16a931a5-faf4-451a-b771-9d40c63ba62c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""LeftSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""69cf3b73-7ae2-4157-972e-b878720c1524"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""LeftSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With Two Modifiers"",
                    ""id"": ""dda245c8-a301-4d9c-a880-4d00f3f0e02b"",
                    ""path"": ""ButtonWithTwoModifiers"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightSpin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier1"",
                    ""id"": ""fe656e34-60c2-40b3-a12c-99645849e1e3"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""RightSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""modifier2"",
                    ""id"": ""580a6b7c-c7c3-4ac8-a267-0711f97af012"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""RightSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""7dc26f3c-9dcb-4462-a4d9-8a6ad8311542"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""RightSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With Two Modifiers"",
                    ""id"": ""e09325c5-75ad-4341-9967-ab7dfc6a951d"",
                    ""path"": ""ButtonWithTwoModifiers"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackSpin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier1"",
                    ""id"": ""0f7360e4-d4ac-47fc-82da-a333f562eab0"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""BackSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""modifier2"",
                    ""id"": ""7210e772-ed89-48c9-9f75-7c314b37bdee"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""BackSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""f640bc13-0838-4bf7-8fec-7f11c1d7cfbb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""BackSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4284c983-0608-46dd-b3f0-84ae355cad94"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gampad"",
                    ""action"": ""FloatUp"",
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
            ""name"": ""Gampad"",
            ""bindingGroup"": ""Gampad"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_BackFlip = m_Player.FindAction("BackFlip", throwIfNotFound: true);
        m_Player_RightRoll = m_Player.FindAction("RightRoll", throwIfNotFound: true);
        m_Player_LeftRoll = m_Player.FindAction("LeftRoll", throwIfNotFound: true);
        m_Player_StartFlip = m_Player.FindAction("StartFlip", throwIfNotFound: true);
        m_Player_FrontSpin = m_Player.FindAction("FrontSpin", throwIfNotFound: true);
        m_Player_LeftSpin = m_Player.FindAction("LeftSpin", throwIfNotFound: true);
        m_Player_RightSpin = m_Player.FindAction("RightSpin", throwIfNotFound: true);
        m_Player_BackSpin = m_Player.FindAction("BackSpin", throwIfNotFound: true);
        m_Player_FloatUp = m_Player.FindAction("FloatUp", throwIfNotFound: true);
        m_Player_FloatDown = m_Player.FindAction("FloatDown", throwIfNotFound: true);
        m_Player_NoseDive = m_Player.FindAction("NoseDive", throwIfNotFound: true);
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
    private readonly InputAction m_Player_BackFlip;
    private readonly InputAction m_Player_RightRoll;
    private readonly InputAction m_Player_LeftRoll;
    private readonly InputAction m_Player_StartFlip;
    private readonly InputAction m_Player_FrontSpin;
    private readonly InputAction m_Player_LeftSpin;
    private readonly InputAction m_Player_RightSpin;
    private readonly InputAction m_Player_BackSpin;
    private readonly InputAction m_Player_FloatUp;
    private readonly InputAction m_Player_FloatDown;
    private readonly InputAction m_Player_NoseDive;
    public struct PlayerActions
    {
        private @PS4PlayerMovement m_Wrapper;
        public PlayerActions(@PS4PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @BackFlip => m_Wrapper.m_Player_BackFlip;
        public InputAction @RightRoll => m_Wrapper.m_Player_RightRoll;
        public InputAction @LeftRoll => m_Wrapper.m_Player_LeftRoll;
        public InputAction @StartFlip => m_Wrapper.m_Player_StartFlip;
        public InputAction @FrontSpin => m_Wrapper.m_Player_FrontSpin;
        public InputAction @LeftSpin => m_Wrapper.m_Player_LeftSpin;
        public InputAction @RightSpin => m_Wrapper.m_Player_RightSpin;
        public InputAction @BackSpin => m_Wrapper.m_Player_BackSpin;
        public InputAction @FloatUp => m_Wrapper.m_Player_FloatUp;
        public InputAction @FloatDown => m_Wrapper.m_Player_FloatDown;
        public InputAction @NoseDive => m_Wrapper.m_Player_NoseDive;
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
                @BackFlip.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackFlip;
                @BackFlip.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackFlip;
                @BackFlip.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackFlip;
                @RightRoll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightRoll;
                @RightRoll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightRoll;
                @RightRoll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightRoll;
                @LeftRoll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftRoll;
                @LeftRoll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftRoll;
                @LeftRoll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftRoll;
                @StartFlip.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartFlip;
                @StartFlip.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartFlip;
                @StartFlip.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartFlip;
                @FrontSpin.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFrontSpin;
                @FrontSpin.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFrontSpin;
                @FrontSpin.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFrontSpin;
                @LeftSpin.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftSpin;
                @LeftSpin.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftSpin;
                @LeftSpin.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftSpin;
                @RightSpin.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightSpin;
                @RightSpin.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightSpin;
                @RightSpin.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightSpin;
                @BackSpin.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackSpin;
                @BackSpin.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackSpin;
                @BackSpin.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackSpin;
                @FloatUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloatUp;
                @FloatUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloatUp;
                @FloatUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloatUp;
                @FloatDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloatDown;
                @FloatDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloatDown;
                @FloatDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloatDown;
                @NoseDive.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNoseDive;
                @NoseDive.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNoseDive;
                @NoseDive.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNoseDive;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @BackFlip.started += instance.OnBackFlip;
                @BackFlip.performed += instance.OnBackFlip;
                @BackFlip.canceled += instance.OnBackFlip;
                @RightRoll.started += instance.OnRightRoll;
                @RightRoll.performed += instance.OnRightRoll;
                @RightRoll.canceled += instance.OnRightRoll;
                @LeftRoll.started += instance.OnLeftRoll;
                @LeftRoll.performed += instance.OnLeftRoll;
                @LeftRoll.canceled += instance.OnLeftRoll;
                @StartFlip.started += instance.OnStartFlip;
                @StartFlip.performed += instance.OnStartFlip;
                @StartFlip.canceled += instance.OnStartFlip;
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
                @FloatUp.started += instance.OnFloatUp;
                @FloatUp.performed += instance.OnFloatUp;
                @FloatUp.canceled += instance.OnFloatUp;
                @FloatDown.started += instance.OnFloatDown;
                @FloatDown.performed += instance.OnFloatDown;
                @FloatDown.canceled += instance.OnFloatDown;
                @NoseDive.started += instance.OnNoseDive;
                @NoseDive.performed += instance.OnNoseDive;
                @NoseDive.canceled += instance.OnNoseDive;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GampadSchemeIndex = -1;
    public InputControlScheme GampadScheme
    {
        get
        {
            if (m_GampadSchemeIndex == -1) m_GampadSchemeIndex = asset.FindControlSchemeIndex("Gampad");
            return asset.controlSchemes[m_GampadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnBackFlip(InputAction.CallbackContext context);
        void OnRightRoll(InputAction.CallbackContext context);
        void OnLeftRoll(InputAction.CallbackContext context);
        void OnStartFlip(InputAction.CallbackContext context);
        void OnFrontSpin(InputAction.CallbackContext context);
        void OnLeftSpin(InputAction.CallbackContext context);
        void OnRightSpin(InputAction.CallbackContext context);
        void OnBackSpin(InputAction.CallbackContext context);
        void OnFloatUp(InputAction.CallbackContext context);
        void OnFloatDown(InputAction.CallbackContext context);
        void OnNoseDive(InputAction.CallbackContext context);
    }
}