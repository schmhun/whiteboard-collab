using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMessage : MonoBehaviour {
    public enum MessageType
    {
        creation,
        movement,
        point,
    }

    public int boardId;
    public float x;
    public float y;
    public float z;

}
