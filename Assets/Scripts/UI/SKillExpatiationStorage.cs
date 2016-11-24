﻿using System.Collections.Generic;

public class SKillExpatiationStorage  {
    public enum CharacterType
    {
        Warrior,
        Mage,
        ShieldWarrior,
        Gunner
    }
   
    Dictionary<string, SkillInfo> skillDic = new Dictionary<string, SkillInfo>();
    
    void SetDictionary()
    {
        skillDic.Add("전사스킬1", new SkillInfo(SkillInfo.SkillType.Active, "섬단", 5, "캐릭터가 빠른속도로 전방의 적들을 베어버린다."));
       
    }
}

public class SkillInfo
{
    public enum SkillType
    {
        Active,
        Passive
    }

    string skillType;
    string skillName;
    string skillExplanation;
    int skillCoolTime;
 
    public SkillInfo(SkillType _skillType, string _skillName, int _skillCoolTime ,string _skillExplanation)
    { 
        skillType = _skillType.ToString();
        skillName = _skillName;
        skillCoolTime = _skillCoolTime;
        skillExplanation = _skillExplanation;
    }
    


}