using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackOverlayWindowScript : WindowScript {
	public static AttackOverlayWindowScript instance;

	void Awake(){
		instance = this;
	}

	public Text SwordManCounter;
	public Text ArcherCounter;

	public void OnClickNextButton(){
		Scenman.instance.EnterAttackMode ();
	}

	public void OnClickHomeGoButton(){
		Scenman.instance.EnterNormalMode ();
	}
		
	public void OnClickSwordManButton(){
		Scenman.instance.selectedUnit = 0;
	}

	public void OnClickArcherButton(){
		Scenman.instance.selectedUnit = 1;
	}
}
