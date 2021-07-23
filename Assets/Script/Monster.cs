using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    #region ���
    [Header("���ʳt��"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("�����O"), Range(0, 500)]
    public int attack = 100;
    [Range(0,5000)]
    public int Hp = 350;
    [Header("�����D��"),Tooltip("�C������")]
    public float stuff ;
    [Header("�����D����v"), Range(0,1)]
    public float stuffChance;
    [Header("�����D�㭵��"), Tooltip("AudioClip")]
    public bool AudioClip = true;
    private AudioSource audioSource ;
    private Rigidbody2D rigidbody2D ;
    private Animator animator;
    #endregion
   
}
