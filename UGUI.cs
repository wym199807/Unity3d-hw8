using UnityEngine;
using UnityEngine.UI;

public class UGUI : MonoBehaviour
{
    public Button AddButton, SubButton;
    public RectTransform BloodBar;
    public int reduceBlood = 0;

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * 10 * Time.deltaTime, 0, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * 10 * Time.deltaTime);

        Vector2 vec2 = Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
        BloodBar.GetChild(0).GetComponent<RectTransform>().Right(reduceBlood * 30 + 10);
        BloodBar.anchoredPosition = new Vector2(vec2.x - Screen.width / 2 + 0, vec2.y - Screen.height / 2 + 50);
        AddButton.transform.localPosition = new Vector2(vec2.x - Screen.width / 2 - 60, vec2.y - Screen.height / 2 - 60);
        SubButton.transform.localPosition = new Vector2(vec2.x - Screen.width / 2 + 60, vec2.y - Screen.height / 2 - 60);
    }

    void Start()
    {
        transform.Find("Canvas").gameObject.SetActive(true);
        AddButton.onClick.AddListener(AddHP);
        SubButton.onClick.AddListener(SubHP);
    }

    private void AddHP()
    {
        if (reduceBlood > 0)
        {
            reduceBlood--;
        }
    }

    private void SubHP()
    {
        if (reduceBlood < 25)
        {
            reduceBlood++;
        }
    }
}