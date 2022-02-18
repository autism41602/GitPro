using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterial : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshFilter mf;

    void Start()
    {
        mf = GetComponent<MeshFilter>();
        Mesh mesh = null;
        if (mf != null)
        {
            mesh = mf.mesh;
        }

        if (mesh == null || mesh.uv.Length != 24)
        {
            Debug.Log("Attach To Cube");
            return;
        }

        var uvs = mesh.uv;

        float size = 1.0f;
        //Front
        uvs[0] = new Vector2(0.0f, 0.0f);
        uvs[1] = new Vector2(size / 3.0f, 0.0f);
        uvs[2] = new Vector2(0.0f, size / 3.0f);
        uvs[3] = new Vector2(size / 3.0f, size / 3.0f);

        //back
        uvs[6] = new Vector2(size / 3.0f, size / 3.0f);
        uvs[7] = new Vector2((size + 1) / 3.0f, size / 3.0f);
        uvs[10] = new Vector2(size / 3.0f, (size + 1) / 3.0f);
        uvs[11] = new Vector2((size + 1) / 3.0f, (size + 1) / 3.0f);

        //Top
        uvs[8] = new Vector2(size / 3.0f, 0.0f);
        uvs[9] = new Vector2((size + 1) / 3.0f, 0.0f);
        uvs[4] = new Vector2(size / 3.0f, size / 3.0f);
        uvs[5] = new Vector2((size + 1) / 3.0f, size / 3.0f);

        //Bottom
        uvs[12] = new Vector2(0.0f, size / 3.0f);
        uvs[13] = new Vector2(size / 3.0f, size / 3.0f);
        uvs[15] = new Vector2(0.0f, (size + 1) / 3.0f);
        uvs[14] = new Vector2(size / 3.0f, (size + 1) / 3.0f);

        //Left
        uvs[19] = new Vector2((size + 1) / 3.0f, size / 3.0f);
        uvs[16] = new Vector2((size + 2) / 3.0f, size / 3.0f);
        uvs[17] = new Vector2((size + 2) / 3.0f, (size + 1) / 3.0f);
        uvs[18] = new Vector2((size + 1) / 3.0f, (size + 1) / 3.0f);

        //Right
        uvs[22] = new Vector2((size + 1) / 3.0f, 0.0f);
        uvs[23] = new Vector2((size + 1) / 3.0f, size / 3.0f);
        uvs[20] = new Vector2((size + 2) / 3.0f, size / 3.0f);
        uvs[21] = new Vector2((size + 2) / 3.0f, 0.0f);
        
        mesh.uv = uvs;
    }

    // Update is called once per frame
    void Update()
    {
    }
}