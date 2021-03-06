﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MahjongSceneRunningDice : SceneProcedure
{
	public MahjongSceneRunningDice()
	{ }
	public MahjongSceneRunningDice(PROCEDURE_TYPE type, GameScene gameScene)
		:
	base(type, gameScene)
	{ }
	protected override void onInit(SceneProcedure lastProcedure, string intent)
	{
		LayoutTools.SHOW_LAYOUT(LAYOUT_TYPE.LT_DICE);
		// 通知全部角色信息布局全部准备完毕
		ScriptAllCharacterInfo allCharacterInfo = mLayoutManager.getScript(LAYOUT_TYPE.LT_ALL_CHARACTER_INFO) as ScriptAllCharacterInfo;
		allCharacterInfo.notifyStartGame();
		ScriptMahjongFrame mahjongFrame = mLayoutManager.getScript(LAYOUT_TYPE.LT_MAHJONG_FRAME) as ScriptMahjongFrame;
		mahjongFrame.notifyStartGame();
	}
	protected override void onUpdate(float elapsedTime)
	{
		;
	}
	protected override void onExit(SceneProcedure nextProcedure)
	{
		LayoutTools.HIDE_LAYOUT(LAYOUT_TYPE.LT_DICE);
	}
	protected override void onKeyProcess(float elapsedTime)
	{
		;
	}
}