using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Entity {

    public Attributes attributes;
    public AttackAction[] Attacks;

    public List<string> SpecialAbilities;

    public List<string> Spells;

    public List<string> Languages;


    public int[] SpellsAvailable;

    public int curHP;
    public int totHP;

}
