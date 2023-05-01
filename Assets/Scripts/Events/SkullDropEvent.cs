using UnityEngine;

public class SkullDropEvent : MonoBehaviour
{
    [SerializeField] private int keysRequiredToTrigger;
    [SerializeField] private Transform Skulls;
    [SerializeField] private SoundType soundToPlay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerView>() != null && GameService.Instance.GetPlayerController().KeysEquipped >= keysRequiredToTrigger)
        {
            EventService.Instance.SkullDropEvent.InvokeEvent();
            OnSkullDrop();
            GameService.Instance.GetSoundView().PlaySoundEffects(soundToPlay);
            GetComponent<Collider>().enabled = false;
        }
    }

    private void OnSkullDrop()
    {
        Skulls.gameObject.SetActive(true);
    }
}