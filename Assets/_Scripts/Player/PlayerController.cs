using UnityEngine;

namespace StudioX.DoxygenUnityTemplate.Player
{
    /// <summary>
    /// Handles basic player jump behavior using a Rigidbody component.
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        #region Public Variables

        [Header("Jump Settings")]
        [Tooltip("The upward force applied when the player jumps.")]
        public float jumpForce = 5f;

        #endregion

        #region Private Variables

        /// <summary> Reference to the object's Rigidbody component. </summary>
        private Rigidbody _rigidbody;

        #endregion

        #region Unity Methods

        /// <summary>
        /// Initializes required components.
        /// </summary>
        private void Awake()
        {
            SetupComponents();
        }

        /// <summary>
        /// Monitors player input every frame.
        /// </summary>
        private void Update()
        {
            HandleJumpInput();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Retrieves and caches required components such as Rigidbody.
        /// </summary>
        private void SetupComponents()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        /// <summary>
        /// Checks for jump input and applies jump force if triggered.
        /// </summary>
        private void HandleJumpInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PerformJump();
            }
        }

        /// <summary>
        /// Applies an upward force to make the player jump.
        /// </summary>
        private void PerformJump()
        {
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        #endregion
    }
}
