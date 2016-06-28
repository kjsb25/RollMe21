using UnityEngine;
using System.Collections;

public class AttackAction {
    public string Weapon;
    public int AttackModifier;
    public int DieSize;
    public int DamageModifier;
    public int range;

    public Vector2 RollAttack()
    {
        Vector2 result = new Vector2();
        result[0] = (int)Random.Range(1, 21);
        result[1] = result[0] + AttackModifier;
        return result;
    }

    public int RollDamage()
    {
        int result = (int)Random.Range(1, DieSize + 1) + DamageModifier;
        return result;
    }

    public int RollCrit()
    {
        int result = (int)Random.Range(1, DieSize + 1) + DamageModifier + (int)Random.Range(1, DieSize + 1);
        return result;
    }
}
