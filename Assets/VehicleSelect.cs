using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class VehicleSelect : MonoBehaviour
{
    public GameObject Player;
    public PlayerController PlayerController;
    public SpriteRenderer PlayerSpriteRenderer;
    public PlayerController Bike;
    public PlayerController Car;
    public PlayerController Van;
    public UnityEngine.UI.Image BGPanel;
    public RectTransform Menu;

    [Header("Buttons")]
    public UnityEngine.UI.Button BikeButton;
    public UnityEngine.UI.Button CarButton;
    public UnityEngine.UI.Button VanButton;

    private void Awake()
    {
        PlayerController = Player.GetComponent<PlayerController>();
        //Player.SetActive(false);
    }

    public void SelectBike()
    {
        PlayerController.maxSpeed = Bike.maxSpeed;
        PlayerController.acceleration = Bike.acceleration;
        PlayerController.deceleration = Bike.deceleration;
        PlayerController.turnSpeed = Bike.turnSpeed;
        PlayerController.CarType = PlayerController.CarTypes.BIKE;

        PlayerSpriteRenderer.color = Color.red;

        StartCoroutine(FadeIn());
        DisableButtons();
    }

    public void SelectCar()
    {
        PlayerController.maxSpeed = Car.maxSpeed;
        PlayerController.acceleration = Car.acceleration;
        PlayerController.deceleration = Car.deceleration;
        PlayerController.turnSpeed = Car.turnSpeed;
        PlayerController.CarType = PlayerController.CarTypes.CAR;

        PlayerSpriteRenderer.color = Color.green;

        StartCoroutine(FadeIn());
    }
    public void SelectVan()
    {
        PlayerController.maxSpeed = Van.maxSpeed;
        PlayerController.acceleration = Van.acceleration;
        PlayerController.deceleration = Van.deceleration;
        PlayerController.turnSpeed = Van.turnSpeed;
        PlayerController.CarType = PlayerController.CarTypes.VAN;

        PlayerSpriteRenderer.color = Color.blue;

        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        float duration = 2f;
        float t = 0f;

        Color c = BGPanel.color;
        float startAlpha = c.a;
        float endAlpha = 0f;

        while (t < duration)
        {
            t += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startAlpha, endAlpha, t / duration);

            c.a = newAlpha;
            BGPanel.color = c;

            Menu.position = new Vector2(Menu.position.x, Menu.position.y - t);

            yield return null;
        }

        Menu.position = new Vector2(1000,3000);
    }

    private void DisableButtons()
    {
        BikeButton.enabled = false;
        CarButton.enabled = false;
        VanButton.enabled = false;
    }
}
