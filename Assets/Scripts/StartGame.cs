using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public bool buttonPressed;
    public Animator buttonAnimator; // Reference to the button's Animator

    // Add a method to trigger the animation and then load the scene
    private IEnumerator PlayAnimationAndLoadScene() {
        // Play the animation
        buttonAnimator.SetTrigger("Pressed"); // Trigger your animation (ensure you have a "Pressed" trigger in the Animator)

        // Wait for the duration of the animation (assuming 1 second, adjust as needed)
        yield return new WaitForSeconds(1f); // Adjust the time according to your animation's length

        // After the animation ends, load the scene
        SceneManager.LoadScene("SampleScene");
    }

    public void OnPointerDown(PointerEventData eventData) {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData) {
        buttonPressed = false;
    }

    void Update() {
        if (buttonPressed) {
            // Start the animation and scene load sequence
            StartCoroutine(PlayAnimationAndLoadScene());
            buttonPressed = false; // Prevent repeated triggers
        }
    }
}

