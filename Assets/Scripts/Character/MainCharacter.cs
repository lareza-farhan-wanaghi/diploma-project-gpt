using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
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
}
