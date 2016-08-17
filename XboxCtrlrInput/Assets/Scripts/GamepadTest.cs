using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using XboxCtrlrInput;

public class GamepadTest : MonoBehaviour
{
    [SerializeField]
    private Text t;

    private void Update()
    {
        t.text = string.Format(
                               "<b>XBOX ONE GAMPAD/CONTROLLER/JOYSTICK</b>\n\n" +
                               "\n<b>Stick Left Y:</b> {0}" +
                               "\n<b>Stick Left X:</b> {1}" +
                               "\n<b>Stick Right X:</b> {2}" +
                               "\n<b>Stick Right Y:</b> {3}" +
                               "\n<b>D-Pad Up:</b> {4}" +
                               "\n<b>D-Pad Down:</b> {5}" +
                               "\n<b>D-Pad Left:</b> {6}" +
                               "\n<b>D-Pad Right:</b> {7}" +
                               "\n<b>Trigger Left:</b> {8}" +
                               "\n<b>Trigger Right:</b> {9}" +
                               "\n<b>Bump Left:</b> {10}" +
                               "\n<b>Bump Right:</b> {11}" +
                               "\n<b>Button A:</b> {12}" +
                               "\n<b>Button B:</b> {13}" +
                               "\n<b>Button X:</b> {14}" +
                               "\n<b>Button Y:</b> {15}" +
                               "\n<b>Button Stick Left:</b> {16}" +
                               "\n<b>Button Stick Right:</b> {17}" +
                               "\n<b>Button Back:</b> {18}" +
                               "\n<b>Button Start:</b> {19}"
                               ,
                               XCI.GetAxis(XboxAxis.LeftStickY),
                               XCI.GetAxis(XboxAxis.LeftStickX),
                               XCI.GetAxis(XboxAxis.RightStickX),
                               XCI.GetAxis(XboxAxis.RightStickY),
                               XCI.GetDPad(XboxDPad.Up),
                               XCI.GetDPad(XboxDPad.Down),
                               XCI.GetDPad(XboxDPad.Left),
                               XCI.GetDPad(XboxDPad.Right),
                               XCI.GetAxis(XboxAxis.LeftTrigger),
                               XCI.GetAxis(XboxAxis.RightTrigger),
                               XCI.GetButton(XboxButton.LeftBumper),
                               XCI.GetButton(XboxButton.RightBumper),
                               XCI.GetButton(XboxButton.A),
                               XCI.GetButton(XboxButton.B),
                               XCI.GetButton(XboxButton.X),
                               XCI.GetButton(XboxButton.Y),
                               XCI.GetButton(XboxButton.LeftStick),
                               XCI.GetButton(XboxButton.RightStick),
                               XCI.GetButton(XboxButton.Back),
                               XCI.GetButton(XboxButton.Start));
    }
}
