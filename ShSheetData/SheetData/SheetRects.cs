﻿
// using ReadPDFTextTests.SheetData;
// using SharedCode.ShDataSupport;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using iText.Kernel.Geom;
using ShSheetData.Support;

namespace ShSheetData.SheetData
{
	//
	// [DataContract(Namespace = "")]
	// public class SheetRects
	// {
	// 	private DateTime created;
	// 	private float[] sheetSizeWithRotationA;
	//
	// 	public SheetRects()
	// 	{
	// 		// ShtRects = new Dictionary<SheetMetricId, Rectangle>();
	// 		ShtRects = new Dictionary<SheetRectId, SheetRectData<SheetRectId>>();
	// 		OptRects = new Dictionary<SheetRectId, SheetRectData<SheetRectId>>();
	//
	// 		// ShtRects.Add(SheetMetricId.SM_SHT, new ShtRectData<SheetMetricId, Rectangle>(SheetRectType.SRT_NA, SheetMetricId.SM_SHT));
	// 	}
	//
	// 	[DataMember(Order = 1)]
	// 	public string Name { get; set; }
	//
	// 	[DataMember(Order = 2)]
	// 	public string Description { get; set; }
	//
	// 	[IgnoreDataMember]
	// 	public string Created
	// 	{
	// 		get => created.ToString("O");
	// 		set => created = DateTime.Parse(value, CultureInfo.InvariantCulture);
	// 	}
	//
	// 	[DataMember(Order = 3)]
	// 	public DateTime CreatedDt
	// 	{
	// 		get => created;
	// 		set { created = value; }
	// 	}
	//
	// 	[DataMember(Order = 4)]
	// 	public int SheetRotation { get; set; }
	//
	// 	[IgnoreDataMember]
	// 	public Rectangle PageSizeWithRotation
	// 	{
	// 		get => ShtRects[SheetRectId.SM_SHT].Rect;
	// 		set
	// 		{
	// 			if (ShtRects == null) return;
	//
	// 			if (!ShtRects.ContainsKey(SheetRectId.SM_SHT))
	// 			{
	// 				ShtRects.Add(SheetRectId.SM_SHT, new SheetRectData<SheetRectId>(SheetRectType.SRT_NA, SheetRectId.SM_SHT));
	// 			}
	//
	// 			ShtRects[SheetRectId.SM_SHT].Rect = value;
	//
	// 			if (value != null)
	// 			{
	// 				sheetSizeWithRotationA = new []
	// 				{
	// 					value.GetX(), value.GetY(), value.GetWidth(), value.GetHeight()
	// 				};
	// 			}
	// 			else
	// 			{
	// 				sheetSizeWithRotationA = null;
	// 			}
	// 		}
	// 	}
	//
	// 	[DataMember(Order = 5)]
	// 	public float[] SheetSizeWithRotationA
	// 	{
	// 		get => sheetSizeWithRotationA;
	// 		set
	// 		{
	// 			if (value != null)
	// 			{
	// 				PageSizeWithRotation = new Rectangle(value[0], value[1], value[2], value[3]);
	// 			}
	// 			else
	// 			{
	// 				PageSizeWithRotation = null;
	// 			}
	// 		}
	// 	}
	//
	// 	[IgnoreDataMember]
	// 	public bool IsComplete => AllShtRectsFound;
	//
	// 	[IgnoreDataMember]
	// 	public bool AllShtRectsFound => ShtRects.Count == SheetRectConfigDataSupport.ShtRectsMinQty;
	//
	// 	[IgnoreDataMember]
	// 	public bool AnyOptRectsFound => OptRects.Count > 0;
	//
	// 	// public Dictionary<SheetMetricId, Rectangle> ShtRects { get; set; }
	//
	// 	[DataMember(Order = 5)]
	// 	public Dictionary<SheetRectId, SheetRectData<SheetRectId>> ShtRects { get; set; }
	//
	// 	[DataMember(Order = 6)]
	// 	public Dictionary<SheetRectId, SheetRectData<SheetRectId>> OptRects { get; set; }
	// }

}