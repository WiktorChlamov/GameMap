// GENERATED AUTOMATICALLY FROM 'Assets/Control.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Control : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Control()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Control"",
    ""maps"": [
        {
            ""name"": ""MousePanAndZoom"",
            ""id"": ""a36aa756-fe50-45b1-b3ce-fe8b32bde885"",
            ""actions"": [
                {
                    ""name"": ""Pan"",
                    ""type"": ""PassThrough"",
                    ""id"": ""78e37305-585b-4172-8411-7400a5b09a62"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3ff272c6-a55c-4cc4-a1fe-164e3cb4b4fa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Invert,Normalize(min=-1,max=1)"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9f96657c-e2fe-418c-87fd-8f939564de5b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""463a70d1-9430-424a-8a57-78fb00dcea79"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Sliding"",
            ""id"": ""a9144921-8308-4f0c-9e01-832e4c3dacb3"",
            ""actions"": [
                {
                    ""name"": ""MapSliding"",
                    ""type"": ""Button"",
                    ""id"": ""cf266317-2e63-4284-8e71-2258b878b2f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseAndTouchDelta"",
                    ""type"": ""Value"",
                    ""id"": ""605233b5-8617-46ad-aeeb-b0ac58eccf08"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5ff4a1af-f5e9-4e60-9d70-2b345d618b27"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MapSliding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eddb68d3-91c0-453f-a8ce-229bbd03b2a7"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MapSliding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d787724-bc0f-4840-b2d8-882578462344"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": """",
                    ""action"": ""MouseAndTouchDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ab79fc3-01a7-4814-b377-743909d50cb8"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.1,y=0.1)"",
                    ""groups"": """",
                    ""action"": ""MouseAndTouchDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TouchZooming"",
            ""id"": ""a64e929a-da2b-42d1-9da9-4e51c07be432"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""6522d522-5aaa-48a4-b539-c2929cd165e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryFinger"",
                    ""type"": ""Value"",
                    ""id"": ""5d70a965-2f8c-4642-88d7-74f651617649"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryFinger"",
                    ""type"": ""Value"",
                    ""id"": ""aff66d03-6a7e-49d0-8a51-40b76a062fc4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryContact"",
                    ""type"": ""Button"",
                    ""id"": ""0db2ba88-8666-4daa-a73b-83c3b672fab1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""93a3ae2c-63a2-4079-a0f8-ad67f0675659"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e0705ce-a038-4dd5-b8e0-6dad8f2a184a"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFinger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a52c7a5a-70d3-447d-8997-7d75c7fdc324"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFinger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e6c2ad7-d02a-4047-8742-ba641500f413"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MousePanAndZoom
        m_MousePanAndZoom = asset.FindActionMap("MousePanAndZoom", throwIfNotFound: true);
        m_MousePanAndZoom_Pan = m_MousePanAndZoom.FindAction("Pan", throwIfNotFound: true);
        m_MousePanAndZoom_Zoom = m_MousePanAndZoom.FindAction("Zoom", throwIfNotFound: true);
        // Sliding
        m_Sliding = asset.FindActionMap("Sliding", throwIfNotFound: true);
        m_Sliding_MapSliding = m_Sliding.FindAction("MapSliding", throwIfNotFound: true);
        m_Sliding_MouseAndTouchDelta = m_Sliding.FindAction("MouseAndTouchDelta", throwIfNotFound: true);
        // TouchZooming
        m_TouchZooming = asset.FindActionMap("TouchZooming", throwIfNotFound: true);
        m_TouchZooming_Newaction = m_TouchZooming.FindAction("New action", throwIfNotFound: true);
        m_TouchZooming_PrimaryFinger = m_TouchZooming.FindAction("PrimaryFinger", throwIfNotFound: true);
        m_TouchZooming_SecondaryFinger = m_TouchZooming.FindAction("SecondaryFinger", throwIfNotFound: true);
        m_TouchZooming_SecondaryContact = m_TouchZooming.FindAction("SecondaryContact", throwIfNotFound: true);
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

    // MousePanAndZoom
    private readonly InputActionMap m_MousePanAndZoom;
    private IMousePanAndZoomActions m_MousePanAndZoomActionsCallbackInterface;
    private readonly InputAction m_MousePanAndZoom_Pan;
    private readonly InputAction m_MousePanAndZoom_Zoom;
    public struct MousePanAndZoomActions
    {
        private @Control m_Wrapper;
        public MousePanAndZoomActions(@Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pan => m_Wrapper.m_MousePanAndZoom_Pan;
        public InputAction @Zoom => m_Wrapper.m_MousePanAndZoom_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_MousePanAndZoom; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MousePanAndZoomActions set) { return set.Get(); }
        public void SetCallbacks(IMousePanAndZoomActions instance)
        {
            if (m_Wrapper.m_MousePanAndZoomActionsCallbackInterface != null)
            {
                @Pan.started -= m_Wrapper.m_MousePanAndZoomActionsCallbackInterface.OnPan;
                @Pan.performed -= m_Wrapper.m_MousePanAndZoomActionsCallbackInterface.OnPan;
                @Pan.canceled -= m_Wrapper.m_MousePanAndZoomActionsCallbackInterface.OnPan;
                @Zoom.started -= m_Wrapper.m_MousePanAndZoomActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_MousePanAndZoomActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_MousePanAndZoomActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_MousePanAndZoomActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pan.started += instance.OnPan;
                @Pan.performed += instance.OnPan;
                @Pan.canceled += instance.OnPan;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public MousePanAndZoomActions @MousePanAndZoom => new MousePanAndZoomActions(this);

    // Sliding
    private readonly InputActionMap m_Sliding;
    private ISlidingActions m_SlidingActionsCallbackInterface;
    private readonly InputAction m_Sliding_MapSliding;
    private readonly InputAction m_Sliding_MouseAndTouchDelta;
    public struct SlidingActions
    {
        private @Control m_Wrapper;
        public SlidingActions(@Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @MapSliding => m_Wrapper.m_Sliding_MapSliding;
        public InputAction @MouseAndTouchDelta => m_Wrapper.m_Sliding_MouseAndTouchDelta;
        public InputActionMap Get() { return m_Wrapper.m_Sliding; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SlidingActions set) { return set.Get(); }
        public void SetCallbacks(ISlidingActions instance)
        {
            if (m_Wrapper.m_SlidingActionsCallbackInterface != null)
            {
                @MapSliding.started -= m_Wrapper.m_SlidingActionsCallbackInterface.OnMapSliding;
                @MapSliding.performed -= m_Wrapper.m_SlidingActionsCallbackInterface.OnMapSliding;
                @MapSliding.canceled -= m_Wrapper.m_SlidingActionsCallbackInterface.OnMapSliding;
                @MouseAndTouchDelta.started -= m_Wrapper.m_SlidingActionsCallbackInterface.OnMouseAndTouchDelta;
                @MouseAndTouchDelta.performed -= m_Wrapper.m_SlidingActionsCallbackInterface.OnMouseAndTouchDelta;
                @MouseAndTouchDelta.canceled -= m_Wrapper.m_SlidingActionsCallbackInterface.OnMouseAndTouchDelta;
            }
            m_Wrapper.m_SlidingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MapSliding.started += instance.OnMapSliding;
                @MapSliding.performed += instance.OnMapSliding;
                @MapSliding.canceled += instance.OnMapSliding;
                @MouseAndTouchDelta.started += instance.OnMouseAndTouchDelta;
                @MouseAndTouchDelta.performed += instance.OnMouseAndTouchDelta;
                @MouseAndTouchDelta.canceled += instance.OnMouseAndTouchDelta;
            }
        }
    }
    public SlidingActions @Sliding => new SlidingActions(this);

    // TouchZooming
    private readonly InputActionMap m_TouchZooming;
    private ITouchZoomingActions m_TouchZoomingActionsCallbackInterface;
    private readonly InputAction m_TouchZooming_Newaction;
    private readonly InputAction m_TouchZooming_PrimaryFinger;
    private readonly InputAction m_TouchZooming_SecondaryFinger;
    private readonly InputAction m_TouchZooming_SecondaryContact;
    public struct TouchZoomingActions
    {
        private @Control m_Wrapper;
        public TouchZoomingActions(@Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_TouchZooming_Newaction;
        public InputAction @PrimaryFinger => m_Wrapper.m_TouchZooming_PrimaryFinger;
        public InputAction @SecondaryFinger => m_Wrapper.m_TouchZooming_SecondaryFinger;
        public InputAction @SecondaryContact => m_Wrapper.m_TouchZooming_SecondaryContact;
        public InputActionMap Get() { return m_Wrapper.m_TouchZooming; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchZoomingActions set) { return set.Get(); }
        public void SetCallbacks(ITouchZoomingActions instance)
        {
            if (m_Wrapper.m_TouchZoomingActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnNewaction;
                @PrimaryFinger.started -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnPrimaryFinger;
                @PrimaryFinger.performed -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnPrimaryFinger;
                @PrimaryFinger.canceled -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnPrimaryFinger;
                @SecondaryFinger.started -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnSecondaryFinger;
                @SecondaryFinger.performed -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnSecondaryFinger;
                @SecondaryFinger.canceled -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnSecondaryFinger;
                @SecondaryContact.started -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnSecondaryContact;
                @SecondaryContact.performed -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnSecondaryContact;
                @SecondaryContact.canceled -= m_Wrapper.m_TouchZoomingActionsCallbackInterface.OnSecondaryContact;
            }
            m_Wrapper.m_TouchZoomingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
                @PrimaryFinger.started += instance.OnPrimaryFinger;
                @PrimaryFinger.performed += instance.OnPrimaryFinger;
                @PrimaryFinger.canceled += instance.OnPrimaryFinger;
                @SecondaryFinger.started += instance.OnSecondaryFinger;
                @SecondaryFinger.performed += instance.OnSecondaryFinger;
                @SecondaryFinger.canceled += instance.OnSecondaryFinger;
                @SecondaryContact.started += instance.OnSecondaryContact;
                @SecondaryContact.performed += instance.OnSecondaryContact;
                @SecondaryContact.canceled += instance.OnSecondaryContact;
            }
        }
    }
    public TouchZoomingActions @TouchZooming => new TouchZoomingActions(this);
    public interface IMousePanAndZoomActions
    {
        void OnPan(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface ISlidingActions
    {
        void OnMapSliding(InputAction.CallbackContext context);
        void OnMouseAndTouchDelta(InputAction.CallbackContext context);
    }
    public interface ITouchZoomingActions
    {
        void OnNewaction(InputAction.CallbackContext context);
        void OnPrimaryFinger(InputAction.CallbackContext context);
        void OnSecondaryFinger(InputAction.CallbackContext context);
        void OnSecondaryContact(InputAction.CallbackContext context);
    }
}
