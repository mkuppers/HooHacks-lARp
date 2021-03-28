using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharGen : MonoBehaviour
{
    public List<GameObject> enemyController;
    public GameObject island;
    string[] bodyParts = new string[] {"head", "face", "body"};
    string[] capStyles = {"under",
                          "straw",
                          "bucket",
                          "flat",
                          "umbrella",
                          "sunhat",
                          "tri"};
    string[] faceStyles = {"eviluwu",
                           "happy",
                           "annoyed",
                           "happywide",
                           "squee",
                           "cat",
                           "tired",
                           "whopee",
                           "smirk",
                           "evil",
                           "mad",
                           "oooh",
                           "ok",
                           "kawaii",
                           "shiny",
                           "lenny",
                           "why",
                           "nyeh",
                           "wut",
                           "oVo",
                           "wowza"};
    string[] bodyStyles = {"vase",
                           "pot",
                           "stick",
                           "rectangle",
                           "ruffle",
                           "hotdog",
                           "legday",
                           "thicc",
                           "starfish",
                           "chonk",
                           "fashion"};


    private void Start()
    {
        

    }

    public GameObject GenerateMushroomChar() {
        GameObject mushChar = new GameObject();
        mushChar.name = "mushCar";
        
        // cap: 0, face: 1, body: 2
        string[] genRandLook = RandomizeLook();
        Sprite capSprite = GenerateCapSprite(genRandLook[0]);
        Sprite faceSprite = GenerateFaceSprite(genRandLook[1]);
        Sprite bodySprite = GenerateBodySprite(genRandLook[2]);
        ArrangeSprites(genRandLook);
        PackageSprites(mushChar);

        mushChar.transform.localScale = new Vector3(1, 1, 1);
        GameObject character = Instantiate(enemyController[(int)Random.Range(0, enemyController.Count)], new Vector3(0,0,0), Quaternion.identity);
        GameObject isle = Instantiate(island, new Vector3(0, -0.3f, 0), Quaternion.identity);
        mushChar.transform.parent = character.transform;
        mushChar.transform.position = new Vector3(0, 0, -0.15f);
        isle.transform.parent = character.transform;
        return character;

    }

    private Sprite GenerateCapSprite(string capStr) {
        GameObject capSpriteGO = new GameObject("capSprite", typeof(SpriteRenderer));
        SpriteRenderer capSpriteRenderer = capSpriteGO.GetComponent<SpriteRenderer>();
        
        Texture2D capTex = Resources.Load(capStr) as Texture2D;
        
        Sprite capSprite = Sprite.Create(capTex,
                                          new Rect(0.0f, 0.0f, capTex.width, capTex.height),
                                          new Vector2(0.5f, 0.5f),
                                          100.0f);
        capSpriteRenderer.sprite = capSprite;
        return capSprite;
    }

    private Sprite GenerateFaceSprite(string faceStr) {
        GameObject faceSpriteGO = new GameObject("faceSprite", typeof(SpriteRenderer));
        SpriteRenderer faceSpriteRenderer = faceSpriteGO.GetComponent<SpriteRenderer>();
        
        Texture2D faceTex = Resources.Load(faceStr) as Texture2D;
        
        Sprite faceSprite = Sprite.Create(faceTex,
                                          new Rect(0.0f, 0.0f, faceTex.width, faceTex.height),
                                          new Vector2(0.5f, 0.5f),
                                          100.0f);
        faceSpriteRenderer.sprite = faceSprite;
        return faceSprite;
    }

    private Sprite GenerateBodySprite(string bodyStr) {
        GameObject bodySpriteGO = new GameObject("bodySprite", typeof(SpriteRenderer));
        SpriteRenderer bodySpriteRenderer = bodySpriteGO.GetComponent<SpriteRenderer>();

        Texture2D bodyTex = Resources.Load(bodyStr) as Texture2D;

        Sprite bodySprite = Sprite.Create(bodyTex,
                                          new Rect(0.0f, 0.0f, bodyTex.width, bodyTex.height),
                                          new Vector2(0.5f, 0.5f),
                                          100.0f);
        bodySpriteRenderer.sprite = bodySprite;
        return bodySprite;
    }

    private void ArrangeSprites(string[] genRandLook) {
        GameObject capSprite = GetCapSpriteGO();
        Vector3 currPos = capSprite.transform.position;

        string thisBody = genRandLook[2];

        switch (thisBody) {
            case "vase":
            case "pot":
            case "stick":
            case "rectangle":
            case "hotdog":
            case "legday":
                capSprite.transform.Translate(currPos.x, currPos.y + 0.15f, currPos.z);
                break;
            default:
                capSprite.transform.Translate(currPos.x, currPos.y + 0.20f, currPos.z);
                break;
        }
    }

    private string[] RandomizeLook() {
        string selectCap = capStyles[Random.Range(0, capStyles.Length)];
        string selectFace = faceStyles[Random.Range(0, faceStyles.Length)];
        string selectBody = bodyStyles[Random.Range(0, bodyStyles.Length)];

        string[] randomLook = new string[] {selectCap, selectFace, selectBody};

        return randomLook;
    }

    private void PackageSprites(GameObject parentGO) {
        GameObject cap = GetCapSpriteGO();
        cap.transform.SetParent(parentGO.transform);
        cap.transform.localPosition = new Vector3(cap.transform.localPosition.x, cap.transform.localPosition.y, cap.transform.localPosition.z + 0.02f);
        GameObject face = GetFaceSpriteGO();
        face.transform.SetParent(parentGO.transform);
        face.transform.localPosition = new Vector3(face.transform.localPosition.x, face.transform.localPosition.y, face.transform.localPosition.z + 0.04f);
        GetBodySpriteGO().transform.SetParent(parentGO.transform);
    }

    private GameObject GetCapSpriteGO() {
        return GameObject.Find("capSprite");
    }

    private GameObject GetFaceSpriteGO() {
        return GameObject.Find("faceSprite");
    }

    private GameObject GetBodySpriteGO() {
        return GameObject.Find("bodySprite");
    }

}   // end script
