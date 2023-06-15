using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float moveSpeed = 5f;
    [SerializeField] Rigidbody2D rb;
    private Vector2 movement;
    private bool enableInputs = true;
    [SerializeField] Animator anim;
    [SerializeField] SpriteRenderer charRenderer;


    private void Update()
    {
        if(!enableInputs) return;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        anim.SetBool("run", movement.magnitude >0);
        charRenderer.flipX=movement.x>0;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!enableInputs) return;
        
        if (other.gameObject.CompareTag("npc"))
        {
            NPC npc = other.gameObject.GetComponent<NPC>();
            if (npc != null && !string.IsNullOrEmpty(npc.DialogueData))
            {
                EventSystem.instance.TriggerEvent(new EventData(IngameEventType.TalkingWithNPC, other.gameObject.name));
            }
        }
        else if (other.gameObject.CompareTag("photo-spot"))
        {
            EventSystem.instance.TriggerEvent(new EventData(IngameEventType.TakingAPhoto, other.gameObject.transform.parent.gameObject.name));
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        EventSystem.instance.ClearEventData();
        EventSystem.instance.DisableEventTextUI();
    }

    public void SetEnableInputs(bool _enableInputs){
        enableInputs = _enableInputs;
        movement = Vector2.zero;
        anim.SetBool("run", false);
        charRenderer.flipX=false;
    }
}
