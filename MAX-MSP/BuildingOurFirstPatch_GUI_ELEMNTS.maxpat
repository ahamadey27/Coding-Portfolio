{
	"patcher" : 	{
		"fileversion" : 1,
		"appversion" : 		{
			"major" : 8,
			"minor" : 5,
			"revision" : 7,
			"architecture" : "x64",
			"modernui" : 1
		}
,
		"classnamespace" : "box",
		"rect" : [ 106.0, 84.0, 1188.0, 745.0 ],
		"bglocked" : 0,
		"openinpresentation" : 0,
		"default_fontsize" : 12.0,
		"default_fontface" : 0,
		"default_fontname" : "Arial",
		"gridonopen" : 1,
		"gridsize" : [ 15.0, 15.0 ],
		"gridsnaponopen" : 1,
		"objectsnaponopen" : 1,
		"statusbarvisible" : 2,
		"toolbarvisible" : 1,
		"lefttoolbarpinned" : 0,
		"toptoolbarpinned" : 0,
		"righttoolbarpinned" : 0,
		"bottomtoolbarpinned" : 0,
		"toolbars_unpinned_last_save" : 0,
		"tallnewobj" : 0,
		"boxanimatetime" : 200,
		"enablehscroll" : 1,
		"enablevscroll" : 1,
		"devicewidth" : 0.0,
		"description" : "",
		"digest" : "",
		"tags" : "",
		"style" : "",
		"subpatcher_template" : "",
		"assistshowspatchername" : 0,
		"boxes" : [ 			{
				"box" : 				{
					"id" : "obj-13",
					"maxclass" : "newobj",
					"numinlets" : 0,
					"numoutlets" : 0,
					"patching_rect" : [ 496.103891372680664, 646.753240585327148, 18.0, 22.0 ],
					"text" : "s"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-12",
					"maxclass" : "spectroscope~",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 290.0, 793.0, 300.0, 100.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-9",
					"maxclass" : "scope~",
					"numinlets" : 2,
					"numoutlets" : 0,
					"patching_rect" : [ 290.0, 645.0, 130.0, 130.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-41",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 765.5, 652.229249358177185, 206.0, 22.0 ],
					"text" : "MESSAGES WHEN SOUND STOPS"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-40",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 765.5, 556.229249358177185, 212.0, 22.0 ],
					"text" : "MESSAGES WHEN SOUND STARTS"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-38",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 623.987964630126953, 695.204845190048218, 45.180722713470459, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-37",
					"linecount" : 2,
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 683.168687343597412, 681.204845190048218, 687.349421143531799, 36.0 ],
					"text" : "5 \"C:/Users/hamad/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM/BLACK_SMITH_ANVAL_MEDIUM_06.wav\""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-36",
					"linecount" : 2,
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 676.168687343597412, 595.783156394958496, 687.349421143531799, 36.0 ],
					"text" : "5 \"C:/Users/hamad/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM/BLACK_SMITH_ANVAL_MEDIUM_06.wav\""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-34",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 615.949145793914795, 612.665146946907043, 45.180722713470459, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-32",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 3,
					"outlettype" : [ "", "", "" ],
					"patching_rect" : [ 624.204830408096313, 556.229249358177185, 93.0, 22.0 ],
					"text" : "route start done"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-3",
					"maxclass" : "meter~",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"patching_rect" : [ 284.0, 582.229249358177185, 122.0, 49.553907036781311 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-31",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 170.129868507385254, 287.951817870140076, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-29",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 2,
					"outlettype" : [ "int", "int" ],
					"patching_rect" : [ 170.129868507385254, 249.397599577903748, 50.0, 22.0 ],
					"text" : "split 0 8"
				}

			}
, 			{
				"box" : 				{
					"basictuning" : 440,
					"clipheight" : 29.0,
					"data" : 					{
						"clips" : [ 							{
								"absolutepath" : "C:/Users/hamad/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM/BLACK_SMITH_ANVAL_MEDIUM_02.wav",
								"filename" : "BLACK_SMITH_ANVAL_MEDIUM_02.wav",
								"filekind" : "audiofile",
								"id" : "u479000510",
								"selection" : [ 0.0, 1.0 ],
								"loop" : 0,
								"content_state" : 								{

								}

							}
, 							{
								"absolutepath" : "C:/Users/hamad/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM/BLACK_SMITH_ANVAL_MEDIUM_03.wav",
								"filename" : "BLACK_SMITH_ANVAL_MEDIUM_03.wav",
								"filekind" : "audiofile",
								"id" : "u815000513",
								"selection" : [ 0.0, 1.0 ],
								"loop" : 0,
								"content_state" : 								{

								}

							}
, 							{
								"absolutepath" : "C:/Users/hamad/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM/BLACK_SMITH_ANVAL_MEDIUM_04.wav",
								"filename" : "BLACK_SMITH_ANVAL_MEDIUM_04.wav",
								"filekind" : "audiofile",
								"id" : "u082000516",
								"selection" : [ 0.0, 1.0 ],
								"loop" : 0,
								"content_state" : 								{

								}

							}
, 							{
								"absolutepath" : "C:/Users/hamad/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM/BLACK_SMITH_ANVAL_MEDIUM_05.wav",
								"filename" : "BLACK_SMITH_ANVAL_MEDIUM_05.wav",
								"filekind" : "audiofile",
								"id" : "u432000519",
								"selection" : [ 0.0, 1.0 ],
								"loop" : 0,
								"content_state" : 								{

								}

							}
, 							{
								"absolutepath" : "C:/Users/hamad/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM/BLACK_SMITH_ANVAL_MEDIUM_06.wav",
								"filename" : "BLACK_SMITH_ANVAL_MEDIUM_06.wav",
								"filekind" : "audiofile",
								"id" : "u279000522",
								"selection" : [ 0.0, 1.0 ],
								"loop" : 0,
								"content_state" : 								{

								}

							}
, 							{
								"absolutepath" : "C:/Users/hamad/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM/BLACK_SMITH_ANVAL_MEDIUM_07.wav",
								"filename" : "BLACK_SMITH_ANVAL_MEDIUM_07.wav",
								"filekind" : "audiofile",
								"id" : "u914000525",
								"selection" : [ 0.0, 1.0 ],
								"loop" : 0,
								"content_state" : 								{

								}

							}
, 							{
								"absolutepath" : "C:/Users/hamad/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM/BLACK_SMITH_ANVAL_MEDIUM_01.wav",
								"filename" : "BLACK_SMITH_ANVAL_MEDIUM_01.wav",
								"filekind" : "audiofile",
								"id" : "u439000528",
								"selection" : [ 0.0, 1.0 ],
								"loop" : 0,
								"content_state" : 								{

								}

							}
 ]
					}
,
					"followglobaltempo" : 0,
					"formantcorrection" : 0,
					"id" : "obj-28",
					"maxclass" : "playlist~",
					"mode" : "basic",
					"numinlets" : 1,
					"numoutlets" : 5,
					"originallength" : [ 0.0, "ticks" ],
					"originaltempo" : 120.0,
					"outlettype" : [ "signal", "signal", "signal", "", "dictionary" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 170.129868507385254, 326.66728663444519, 150.0, 210.0 ],
					"pitchcorrection" : 0,
					"quality" : "basic",
					"timestretch" : [ 0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-26",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 170.129868507385254, 202.760848999023438, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-21",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 170.129868507385254, 161.038959503173828, 29.5, 22.0 ],
					"text" : "- 48"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-15",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 170.129868507385254, 115.584414482116699, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-11",
					"maxclass" : "newobj",
					"numinlets" : 0,
					"numoutlets" : 4,
					"outlettype" : [ "int", "int", "int", "int" ],
					"patching_rect" : [ 170.129868507385254, 50.649350166320801, 50.5, 22.0 ],
					"text" : "key"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-10",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 170.129868507385254, 763.871814727783203, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-8",
					"maxclass" : "gain~",
					"multichannelvariant" : 0,
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "signal", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 170.129868507385254, 582.229249358177185, 22.0, 134.871795177459717 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-6",
					"maxclass" : "ezdac~",
					"numinlets" : 2,
					"numoutlets" : 0,
					"patching_rect" : [ 170.129868507385254, 815.923089623451233, 45.0, 45.0 ]
				}

			}
 ],
		"lines" : [ 			{
				"patchline" : 				{
					"destination" : [ "obj-15", 0 ],
					"source" : [ "obj-11", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-21", 0 ],
					"source" : [ "obj-15", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-26", 0 ],
					"source" : [ "obj-21", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-29", 0 ],
					"source" : [ "obj-26", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-12", 0 ],
					"order" : 0,
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-3", 0 ],
					"order" : 2,
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-32", 0 ],
					"source" : [ "obj-28", 3 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-8", 0 ],
					"order" : 3,
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-9", 0 ],
					"order" : 1,
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-31", 0 ],
					"source" : [ "obj-29", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-28", 0 ],
					"source" : [ "obj-31", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-34", 0 ],
					"order" : 1,
					"source" : [ "obj-32", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-36", 1 ],
					"order" : 0,
					"source" : [ "obj-32", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-37", 0 ],
					"order" : 0,
					"source" : [ "obj-32", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-38", 0 ],
					"order" : 1,
					"source" : [ "obj-32", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-10", 0 ],
					"source" : [ "obj-8", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-6", 1 ],
					"order" : 0,
					"source" : [ "obj-8", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-6", 0 ],
					"order" : 1,
					"source" : [ "obj-8", 0 ]
				}

			}
 ],
		"dependency_cache" : [ 			{
				"name" : "BLACK_SMITH_ANVAL_MEDIUM_01.wav",
				"bootpath" : "~/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"patcherrelativepath" : "../../AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"type" : "WAVE",
				"implicit" : 1
			}
, 			{
				"name" : "BLACK_SMITH_ANVAL_MEDIUM_02.wav",
				"bootpath" : "~/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"patcherrelativepath" : "../../AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"type" : "WAVE",
				"implicit" : 1
			}
, 			{
				"name" : "BLACK_SMITH_ANVAL_MEDIUM_03.wav",
				"bootpath" : "~/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"patcherrelativepath" : "../../AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"type" : "WAVE",
				"implicit" : 1
			}
, 			{
				"name" : "BLACK_SMITH_ANVAL_MEDIUM_04.wav",
				"bootpath" : "~/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"patcherrelativepath" : "../../AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"type" : "WAVE",
				"implicit" : 1
			}
, 			{
				"name" : "BLACK_SMITH_ANVAL_MEDIUM_05.wav",
				"bootpath" : "~/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"patcherrelativepath" : "../../AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"type" : "WAVE",
				"implicit" : 1
			}
, 			{
				"name" : "BLACK_SMITH_ANVAL_MEDIUM_06.wav",
				"bootpath" : "~/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"patcherrelativepath" : "../../AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"type" : "WAVE",
				"implicit" : 1
			}
, 			{
				"name" : "BLACK_SMITH_ANVAL_MEDIUM_07.wav",
				"bootpath" : "~/Desktop/AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"patcherrelativepath" : "../../AUDIO SAMPLES/Viking_Village_Audio/BLACKSMITH/BLACK_SMITH_ANVAL_MEDIUM",
				"type" : "WAVE",
				"implicit" : 1
			}
 ],
		"autosave" : 0,
		"boxgroups" : [ 			{
				"boxes" : [ "obj-32", "obj-36", "obj-34", "obj-40", "obj-41", "obj-37", "obj-38" ]
			}
 ]
	}

}
