using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidContainer : MonoBehaviour
{
    [SerializeField] string liquidType = "Water";//todo: liquid and solid interaction
    //[SerializeField] Color color;
    [SerializeField] ParticleSystem liquidParticleSystem;
    [SerializeField] GameObject liquidObject;
    [SerializeField] bool isPourable = true;
    [SerializeField] float filledLevel = -0.5f;
    [SerializeField] float emptyLevel = 1f;
    [SerializeField] float currentLevel = 1f;
       
    //todo: pour angles, pour rate, liquid type, reaction so library, filling up

    private Transform myTransform;
    private ParticleSystem.EmissionModule emission;
    private Renderer liquidRend;
    private Material liquidMaterial;

    private float pourRate = 0.005f;//ToDo: This should be calculated every frame by the pour angle

    // Use this for initialization
    void Start()
    {
        emission = liquidParticleSystem.emission;
        emission.enabled = false;
        myTransform = transform;
        liquidRend = liquidObject.GetComponent<Renderer>();
        liquidMaterial = liquidObject.GetComponent<Renderer>().material;

        //liquidRend.material.SetColor("_Tint", color); //Doesn't work for some reason
        liquidRend.material.SetFloat("_FillAmount", currentLevel);

        //liquidMaterial.shader.propertyToId();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPourable)
        {


            if ((Vector3.Dot(myTransform.up, Vector3.down) > 0)&&(currentLevel<emptyLevel))//todo: vary pour rate
            {
                emission.enabled = true;
                currentLevel += pourRate;
                if (currentLevel > emptyLevel)
                {
                    currentLevel = emptyLevel;
                }
            }
            else
            {
                emission.enabled = false;
            }

            liquidMaterial.SetFloat("_FillAmount", currentLevel);
        }

    }

    public void SetPourable(bool state)
    {
        isPourable = state;
    }

    public string GetLiquidType()
    {
        return liquidType;
    }
}
