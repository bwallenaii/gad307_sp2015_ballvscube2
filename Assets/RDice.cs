using UnityEngine;
using System.Collections;

public class RDice {

	public static int Roll(int type, int amount = 1)
	{
		int result = 0;
		for (int i = 0; i < amount; ++i) {
			result += Random.Range(1, type);
		}

		return result;
	}
}
