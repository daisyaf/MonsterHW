using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    #region 欄位
    [Header("移動速度"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public int attack = 100;
    [Range(0,5000)]
    public int Hp = 350;
    [Header("掉落道具"),Tooltip("遊戲物件")]
    public float stuff ;
    [Header("掉落道具機率"), Range(0,1)]
    public float stuffChance;
    [Header("掉落道具音效"), Tooltip("AudioClip")]
    public bool AudioClip = true;
    private AudioSource audioSource ;
    private Rigidbody2D rigidbody2D ;
    private Animator animator;
    #endregion
   
}
