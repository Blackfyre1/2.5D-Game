using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDetails : PieceDetails
{
    public int id;
    [SerializeField]
    public List<ActionDetails> Abilities;

    public void moveTo(List <Vector3Int> path, List <string> anim)
    {

    }
}
