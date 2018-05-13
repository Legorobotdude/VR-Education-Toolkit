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

    private Transform _myTransform;
    private ParticleSystem.EmissionModule _emission;
    private Renderer _liquidRend;
    private Material _liquidMaterial;

    private float pourRate = 0.005f;//ToDo: This should be calculated every frame by the pour angle
    private float fillRate = 0.05f;//Amount to fill every particle collision

    // Use this for initialization
    void Start()
    {
        _emission = liquidParticleSystem.emission;
        _emission.enabled = false;
        _myTransform = transform;
        _liquidRend = liquidObject.GetComponent<Renderer>();
        _liquidMaterial = liquidObject.GetComponent<Renderer>().material;

        //liquidRend.material.SetColor("_Tint", color); //Doesn't work for some reason
        _liquidRend.material.SetFloat("_FillAmount", currentLevel);

        //liquidMaterial.shader.propertyToId();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPourable) return;
        if ((Vector3.Dot(_myTransform.up, Vector3.down) > 0) && (currentLevel < emptyLevel)) //todo: vary pour rate
        {
            _emission.enabled = true;
            currentLevel += pourRate;
            if (currentLevel > emptyLevel)
            {
                currentLevel = emptyLevel;
            }
        }
        else
        {
            _emission.enabled = false;
        }

        _liquidMaterial.SetFloat("_FillAmount", currentLevel);
    }

    public void SetPourable(bool state)
    {
        isPourable = state;
    }

    public string GetLiquidType()
    {
        return liquidType;
    }

    private void OnParticleCollision(GameObject other)
    {
        LiquidContainer otherContainer = GetComponent<LiquidContainer>();

        if (otherContainer == null) return;
        
        string type = otherContainer.GetLiquidType();
        if (type == liquidType)
        {
            currentLevel -= fillRate;
        }
        else
        {
            //Insert reactions here
        }

    }
}
