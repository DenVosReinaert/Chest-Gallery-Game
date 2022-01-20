using UnityEngine;

public class Chest : MonoBehaviour, IInteractable, ILockable
{
    public bool open;

    public bool locked { get; set; }
    public bool locked_;

    public int lockCount { get; set; }
    public int lockCount_;

    public Animator anim;

    void Start()
    {

    }

    void Update()
    {
        locked_ = locked;
        lockCount_ = lockCount;
    }

    public void Interact()
    {
        if (locked)
        {
            Unlock();
        }
        else
        {
            Open();
        }

    }

    public void Unlock()
    {
        if (lockCount > 0)
        {
            dynamicInventory.baseKeys--;
            lockCount--;
        }

        if (lockCount == 0)
        {
            locked = false;
        }
    }

    public void Open()
    {
        if (!open)
        {
            anim.SetTrigger("Open");
            open = true;
        }
    }
}
