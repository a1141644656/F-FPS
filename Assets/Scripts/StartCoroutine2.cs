// In this example we show how to invoke a coroutine and wait until it
// is completed

using UnityEngine;
using System.Collections;

public class StartCoroutine2 : MonoBehaviour
{
    IEnumerator Start()
    {
        // - After 0 seconds, prints "Starting 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
        // - After 2 seconds, prints "Done 2.0"
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine. And wait until it is completed.
        // the same as yield WaitAndPrint(2.0);
        yield return StartCoroutine(WaitAndPrint2(2.0F));
        print("Done " + Time.time);
    }

    // suspend execution for waitTime seconds
    IEnumerator WaitAndPrint2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("WaitAndPrint " + Time.time);
    }
}