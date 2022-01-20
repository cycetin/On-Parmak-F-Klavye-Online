using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class FingerPlacement : MonoBehaviour
{
	public Button buttonEsc;
	public Button buttonF1;
	public Button buttonF2;
	public Button buttonF3;
	public Button buttonF4;
	public Button buttonF5;
	public Button buttonF6;
	public Button buttonF7;
	public Button buttonF8;
	public Button buttonF9;
	public Button buttonF10;
	public Button buttonF11;
	public Button buttonF12;
	public Button buttonStar;
	public Button button1;
	public Button button2;
	public Button button3;
	public Button button4;
	public Button button5;
	public Button button6;
	public Button button7;
	public Button button8;
	public Button button9;
	public Button button0;
	public Button buttonQuestion;
	public Button buttonMinus;
	public Button buttonBs;
	public Button buttonTab;
    public Button buttonF;
	public Button buttonG;
	public Button buttonG2;
	public Button buttonBigi;
	public Button buttonO;
	public Button buttonD;
	public Button buttonR;
	public Button buttonN;
	public Button buttonH;
	public Button buttonP;
	public Button buttonW;
	public Button buttonEnter;
	public Button buttonCaps;
	public Button buttonSWithDot;
	public Button buttonX;
	public Button buttonLShift;
	public Button buttonGreater;
	public Button buttonJ;
	public Button buttonOWithDots;
	public Button buttonV;
	public Button buttonC;
	public Button buttonCWithDot;
	public Button buttonZ;
	public Button buttonS;
	public Button buttonB;
	public Button buttonDoubleDot;
	public Button buttonDotWithComma;
	public Button buttonRShift;
	public Button buttonLCtrl;	
	public Button buttonLAlt;
	public Button buttonRAlt;	
	public Button buttonRCtrl;
	public Button buttonA;
	public Button buttonE;
	public Button buttoni;
	public Button buttonU;
	public Button buttonK;
	public Button buttonM;
	public Button buttonL;
	public Button buttonY;
	public Button buttonT;
	public Button spaceBar;
	public Button buttonUWithDot;
	public Button buttonQ;
	public AudioSource keySound;
	private float thrust = 1;




	void Start()
	{


	

	}

	private void Update()
	{

		if (buttonA.transform.position.y > 1000)
		{
			buttonA.GetComponent<Rigidbody>().velocity = Vector3.zero;
			buttonA.transform.position = new Vector3(buttonT.transform.position.x - 120, buttonT.transform.position.y, buttonT.transform.position.z);
			thrust = 1;

		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			keySound.Play();

			thrust += 20f;
			buttonA.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
			buttonA.GetComponent<Rigidbody>().AddForce(Vector3.left * thrust * 2, ForceMode.Impulse);
		}

		if (buttonE.transform.position.y > 1000)
		{
			buttonE.GetComponent<Rigidbody>().velocity = Vector3.zero;
			buttonE.transform.position = new Vector3(buttonT.transform.position.x - 180, buttonT.transform.position.y, buttonT.transform.position.z);
			thrust = 1;

		}
		if (Input.GetKeyDown(KeyCode.E))
		{
			keySound.Play();

			thrust += 20f;
			buttonE.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
			buttonE.GetComponent<Rigidbody>().AddForce(Vector3.left * thrust * 2, ForceMode.Impulse);

		}

		if (buttoni.transform.position.y > 1000)
		{
			buttoni.GetComponent<Rigidbody>().velocity = Vector3.zero;
			buttoni.transform.position = new Vector3(buttonT.transform.position.x - 240, buttonT.transform.position.y, buttonT.transform.position.z);
			thrust = 1;

		}
		if (Input.inputString.Equals("i") || Input.inputString.Equals("İ"))
		{
			keySound.Play();

			thrust += 20f;
			buttoni.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
			buttoni.GetComponent<Rigidbody>().AddForce(Vector3.left * thrust * 2, ForceMode.Impulse);

		}

		if (buttonU.transform.position.y > 1000)
		{
			buttonU.GetComponent<Rigidbody>().velocity = Vector3.zero;
			buttonU.transform.position = new Vector3(buttonT.transform.position.x - 300, buttonT.transform.position.y, buttonT.transform.position.z);
			thrust = 1;

		}
		if (Input.GetKeyDown(KeyCode.U))
		{
			keySound.Play();

			thrust += 20f;
			buttonU.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
			buttonU.GetComponent<Rigidbody>().AddForce(Vector3.left * thrust * 2, ForceMode.Impulse);

		}

		if (buttonK.transform.position.y > 1000)
		{
			buttonK.GetComponent<Rigidbody>().velocity = Vector3.zero;
			buttonK.transform.position = new Vector3(buttonT.transform.position.x + 60, buttonT.transform.position.y, buttonT.transform.position.z);
			thrust = 1;

		}
		if (Input.GetKeyDown(KeyCode.K))
		{
			keySound.Play();

			thrust += 20f;
			buttonK.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
			buttonK.GetComponent<Rigidbody>().AddForce(Vector3.right * thrust * 2, ForceMode.Impulse);

		}

		if (buttonM.transform.position.y > 1000)
		{
			buttonM.GetComponent<Rigidbody>().velocity = Vector3.zero;
			buttonM.transform.position = new Vector3(buttonT.transform.position.x + 120, buttonT.transform.position.y, buttonT.transform.position.z);
			thrust = 1;

		}
		if (Input.GetKeyDown(KeyCode.M))
		{
			keySound.Play();

			thrust += 20f;
			buttonM.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
			buttonM.GetComponent<Rigidbody>().AddForce(Vector3.right * thrust * 2, ForceMode.Impulse);

		}

		if (buttonL.transform.position.y > 1000)
		{
			buttonL.GetComponent<Rigidbody>().velocity = Vector3.zero;
			buttonL.transform.position = new Vector3(buttonT.transform.position.x + 180, buttonT.transform.position.y, buttonT.transform.position.z);
			thrust = 1;

		}
		if (Input.GetKeyDown(KeyCode.L))
		{
			keySound.Play();

			thrust += 20f;
			buttonL.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
			buttonL.GetComponent<Rigidbody>().AddForce(Vector3.right * thrust * 2, ForceMode.Impulse);

		}

		if (buttonY.transform.position.y > 1000)
		{
			buttonY.GetComponent<Rigidbody>().velocity = Vector3.zero;
			buttonY.transform.position = new Vector3(buttonT.transform.position.x + 240, buttonT.transform.position.y, buttonT.transform.position.z);
			thrust = 1;

		}
		if (Input.GetKeyDown(KeyCode.Y))
		{
			keySound.Play();
			thrust += 20f;
			buttonY.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
			buttonY.GetComponent<Rigidbody>().AddForce(Vector3.right * thrust * 2, ForceMode.Impulse);

		}


		if (spaceBar.transform.position.y > 1000)
		{
			spaceBar.GetComponent<Rigidbody>().velocity = Vector3.zero;
			spaceBar.transform.position = new Vector3(spaceBar.transform.position.x, buttonT.transform.position.y - 120, spaceBar.transform.position.z);
			thrust = 1;

		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			keySound.Play();
			thrust += 20f;
			spaceBar.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
		}
		///////////////////////////////////////////////////////////////////////////////////////
		
		try
		{
			if (Input.GetKey(KeyCode.Escape))
        {
			buttonEsc.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonEsc.gameObject, 10f);
        }
		if (Input.GetKey(KeyCode.F1))
		{
			buttonF1.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF1.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F2))
		{
			buttonF2.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF2.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F3))
		{
			buttonF3.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF3.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F4))
		{
			buttonF4.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF4.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F5))
		{
			buttonF5.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF5.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F6))
		{
			buttonF6.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF6.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F7))
		{
			buttonF7.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF7.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F8))
		{
			buttonF8.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF8.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F9))
		{
			buttonF9.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF9.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F10))
		{
			buttonF10.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF10.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F11))
		{
			buttonF11.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF11.gameObject, 10f);
		}
		if (Input.GetKey(KeyCode.F12))
		{
			buttonF12.GetComponent<Rigidbody>().useGravity = true;
			Destroy(buttonF12.gameObject, 10f);
		}
			/*Buraya bak
				if (Input.GetKey(KeyCode.Tilde))
				{
					buttonStar.GetComponent<Rigidbody>().useGravity = true;
					Destroy(buttonStar.gameObject, 10f);
				}
			*/
			if (Input.GetKey(KeyCode.Alpha1))
			{
				button1.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button1.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Alpha2))
			{
				button2.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button2.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Alpha3))
			{
				button3.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button3.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Alpha4))
			{
				button4.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button4.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Alpha5))
			{
				button5.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button5.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Alpha6))
			{
				button6.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button6.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Alpha7))
			{
				button7.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button7.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Alpha8))
			{
				button8.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button8.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Alpha9))
			{
				button9.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button9.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Alpha0))
			{
				button0.GetComponent<Rigidbody>().useGravity = true;
				Destroy(button0.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.F))
			{
				buttonF.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonF.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.G))
			{
				buttonG.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonG.gameObject, 10f);
			}

			if (Input.inputString=="Ğ" || Input.inputString=="ğ")
			{
				buttonG2.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonG2.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.I))
			{
				buttonBigi.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonBigi.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.O))
			{
				buttonO.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonO.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.D))
			{
				buttonD.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonD.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.R))
			{
				buttonR.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonR.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.N))
			{
				buttonN.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonN.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.H))
			{
				buttonH.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonH.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.P))
			{
				buttonP.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonP.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.W))
			{
				buttonW.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonW.gameObject, 10f);
			}
			if (Input.inputString=="Ü"||Input.inputString=="ü")
			{
				buttonUWithDot.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonUWithDot.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.T))
			{				

				buttonT.gameObject.SetActive(false);
			}
			if (Input.inputString == "Ş" || Input.inputString == "ş")
			{
				buttonSWithDot.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonSWithDot.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.X))
			{
				buttonX.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonX.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.J))
			{
				buttonJ.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonJ.gameObject, 10f);
			}
			if (Input.inputString == "Ö" || Input.inputString == "ö")
			{
				buttonOWithDots.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonOWithDots.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.V))
			{
				buttonV.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonV.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.C))
			{
				buttonC.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonC.gameObject, 10f);
			}
			if (Input.inputString == "Ç" || Input.inputString == "ç")
			{
				buttonCWithDot.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonCWithDot.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Z))
			{
				buttonZ.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonZ.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.S))
			{
				buttonS.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonS.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.B))
			{
				buttonB.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonB.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.CapsLock))
			{
				buttonCaps.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonCaps.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.LeftShift))
			{
				buttonLShift.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonLShift.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.LeftControl))
			{
				buttonLCtrl.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonLCtrl.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.LeftAlt))
			{
				buttonLAlt.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonLAlt.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.AltGr))
			{
				buttonRAlt.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonRAlt.gameObject, 10f);
			}

			if (Input.GetKey(KeyCode.RightControl))
			{
				buttonRCtrl.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonRCtrl.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.RightShift))
			{
				buttonRShift.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonRShift.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Backspace))
			{
				buttonBs.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonBs.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Tab))
			{
				buttonTab.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonTab.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Return))
			{
				buttonEnter.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonEnter.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Comma))
			{
				buttonDotWithComma.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonDotWithComma.gameObject, 10f);
			}			

			if (Input.GetKey(KeyCode.Period))
			{
				buttonDoubleDot.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonDoubleDot.gameObject, 10f);
			}
			if (Input.GetKey(KeyCode.Q))
			{
				buttonQ.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonQ.gameObject, 10f);
			}
			if (Input.inputString=="<")
			{
				buttonGreater.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonGreater.gameObject, 10f);
			}
			if (Input.inputString == "\"" || Input.inputString=="*"||Input.inputString=="+")
			{
				buttonStar.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonStar.gameObject, 10f);
			}
			if (Input.inputString == "/" || Input.inputString == "?" )
			{
				buttonQuestion.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonQuestion.gameObject, 10f);
			}
			if (Input.inputString == "-" || Input.inputString == "_")
			{
				buttonMinus.GetComponent<Rigidbody>().useGravity = true;
				Destroy(buttonMinus.gameObject, 10f);
			}

		}
        catch (MissingReferenceException)
        {

           
        }
	}
}