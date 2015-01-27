using UnityEngine;
using System.Collections;

public class CharacterAttributes : MonoBehaviour {

	public int Strength = 0;
	public int Intelligence = 0;
	public int Agility = 0;

	int base_hp;
	int base_mp;
	int base_armor;

	void Start(){
		base_hp = 100 + Strength * 10;
		base_mp = 100 + Intelligence * 10;
		base_armor = Agility / 3;
	}
}
