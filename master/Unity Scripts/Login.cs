﻿using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    public GameObject username;
    public GameObject password;
    private string loginUsername;
    private string loginPassword;
    public Text responseText;

    /*Tries to create an account within Firebase */
    public void startRequest () {
        StartCoroutine ("createAccount");
    }

    /*A method that creates an account in Firebase */
    IEnumerator createAccount () {

        loginUsername = username.GetComponent<InputField> ().text;
        loginPassword = password.GetComponent<InputField> ().text;
        WWWForm form = new WWWForm ();
        form.AddField ("email", loginUsername);
        form.AddField ("password", loginPassword);
        form.AddField ("returnSecureToken", "true");

        using (UnityWebRequest www = UnityWebRequest.Post ("https://www.googleapis.com/identitytoolkit/v3/relyingparty/signupNewUser?key=AIzaSyDqee9L7UQ8o9VgUOl9bR57HX2YLnVPQTo", form)) {
            yield return www.SendWebRequest ();
            if (www.isNetworkError || www.isHttpError) {
                Debug.Log (www.error);
            } else {
                Debug.Log ("Form upload complete!");
            }
        }

    }

}