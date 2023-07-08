using System.Collections;
using UnityEngine;

namespace ModIOBrowser
{
    public class Starter : MonoBehaviour
    {
        public RectTransform content;

        void Start()
        {
            Browser.Open(null);
            //StartCoroutine(SetPositionToZeroAfterDelay());
        }


        // this is used to cominsate for the wrong positioning
        IEnumerator SetPositionToZeroAfterDelay()
        {
            // Wait for 1 second
            yield return new WaitForSeconds(1);

            // Then set the position to zero
            Vector3 localPosition = content.localPosition;
            localPosition.z = 0;
            content.localPosition = localPosition;
        }
    }
}
