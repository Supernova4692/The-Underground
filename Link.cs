using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{
	public void OpenBook()
	{
		#if !UNITY_EDITOR
		openWindow("https://mobalytics.gg/blog/absolute-beginners-guide-to-league-of-legends/");
		#endif
	}
	public void OpenCard()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.mobafire.com/league-of-legends/champions");
		#endif
	}
	public void OpenDragon()
	{
		#if !UNITY_EDITOR
		openWindow("https://dignitas.gg/articles/blogs/Unknown/14013/ten-top-tips-to-optimise-your-economy-in-league-of-legends");
		#endif
	}
	public void OpenMap()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.riftherald.com/2016/9/29/13027318/lol-guide-how-to-watch-play-intro");
		#endif
	}
	public void OpenHeartPotion()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.mobafire.com/league-of-legends/champion/evelynn-19");
		#endif
	}
public void OpenHexcore()
	{
		#if !UNITY_EDITOR
		openWindow("https://app.mobalytics.gg/lol/lp/gpi?q_ch_scroll_to=1");
		#endif
	}
	public void OpenSheriff()
	{
		#if !UNITY_EDITOR
		openWindow("https://valorant.fandom.com/wiki/Sheriff");
		#endif
	}
	public void OpenSpike()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.thespike.gg/");
		#endif
	}
	public void OpenRazeGrenade()
	{
		#if !UNITY_EDITOR
		openWindow("https://esportsnewsnow.com/advanced-valorant-raze-guide-724bb5c8e45c");
		#endif
	}
	public void OpenVandal()
	{
		#if !UNITY_EDITOR
		openWindow("https://valorant.fandom.com/wiki/Vandal");
		#endif
	}
	public void OpenHeavyShield()
	{
		#if !UNITY_EDITOR
		openWindow("https://famemass.com/valorant-discord-servers/");
		#endif
	}
	public void OpenLightSheild()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.pcgamer.com/valorant-characters/");
		#endif
	}
	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}