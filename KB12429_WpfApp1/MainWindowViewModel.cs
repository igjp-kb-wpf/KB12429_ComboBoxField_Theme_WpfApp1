﻿using KB12429_WpfApp1.Infrastructure;
using KB12429_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB12429_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
	private ObservableCollection<Prefecture> _prefectures;
	public ObservableCollection<Prefecture> Prefectures
	{
		get { return _prefectures; }
		set { _prefectures = value; OnPropertyChanged(); }
	}

	private ObservableCollection<Person> _people;
	public ObservableCollection<Person> People
	{
		get { return _people; }
		set { _people = value; OnPropertyChanged(); }
	}

    private Random _rnd = new Random();

    public MainWindowViewModel()
    {
		_prefectures = new()
		{
			new() { PrefectureCode = "13", PrefectureName = "東京都"},
            new() { PrefectureCode = "14", PrefectureName = "神奈川県"},
            new() { PrefectureCode = "23", PrefectureName = "愛知県"},
            new() { PrefectureCode = "27", PrefectureName = "大阪府"},
		};

        String[] familyNames = new String[] { "田沢", "玉木", "稲垣", "石橋", "小柳", "池上", "安東", "梅原", "栗林", "岸本", "白石", "杉山", "丹野", "深谷", "赤塚", "小林", "磯野", "北山", "重松", "河田", "宮沢", "坪田", "神戸", "金沢", "倉橋", "豊田", "名取", "植村", "山形", "島崎", "西口", "長島", "土居", "谷口", "長崎", "塚本", "石野", "小野寺", "阪本", "石川", "毛利", "古賀", "柳原", "清田", "陳", "三木", "篠原", "平松", "塩田", "桜田" };
        String[] givenNames = new string[] { "泰三", "裕美子", "幸男", "幸春", "穂香", "一憲", "俊光", "雅之", "季衣", "治虫", "真実", "蒼", "一輝", "重彦", "葵衣", "宏寿", "昌己", "華音", "陽向", "広吉", "夕映", "竹男", "理津子", "奏音", "亜衣", "美代子", "勉", "俊郎", "竜也", "花奈子", "岩夫", "幸平", "瑞稀", "朋之", "信一", "春菜", "優菜", "百恵", "新太郎", "奈緒子", "萌香", "淳", "紗奈", "柚咲", "武一", "豊子", "恵利", "優", "光", "和子" };
        _people = new()
		{
			new() { Name = $"{familyNames[_rnd.Next(familyNames.Length)]} {givenNames[_rnd.Next(givenNames.Length)]}", PrefectureCode = _prefectures[_rnd.Next(_prefectures.Count)].PrefectureCode },
            new() { Name = $"{familyNames[_rnd.Next(familyNames.Length)]} {givenNames[_rnd.Next(givenNames.Length)]}", PrefectureCode = _prefectures[_rnd.Next(_prefectures.Count)].PrefectureCode },
            new() { Name = $"{familyNames[_rnd.Next(familyNames.Length)]} {givenNames[_rnd.Next(givenNames.Length)]}", PrefectureCode = _prefectures[_rnd.Next(_prefectures.Count)].PrefectureCode },
            new() { Name = $"{familyNames[_rnd.Next(familyNames.Length)]} {givenNames[_rnd.Next(givenNames.Length)]}", PrefectureCode = _prefectures[_rnd.Next(_prefectures.Count)].PrefectureCode },
            new() { Name = $"{familyNames[_rnd.Next(familyNames.Length)]} {givenNames[_rnd.Next(givenNames.Length)]}", PrefectureCode = _prefectures[_rnd.Next(_prefectures.Count)].PrefectureCode },
		};
    }
}
