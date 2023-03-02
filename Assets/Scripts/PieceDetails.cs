using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceDetails: MonoBehaviour
{
    public Vector3Int BoardPos;
    public bool CanMove;
    public bool CanWalkOnGround;
    public bool CanWalkOnWall;
    public int Range;
    public List <Vector3Int> Vision;
    public int id;
    // Start is called before the first frame update
    void Start()
    {              
    }
    //Update is called once per frame
    void Update()
    {
    } 
} 