using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage04 : MonoBehaviour
{
    public IDictionary<float, string[]> EnemyData;

    private void Awake()
    {
        EnemyData = new Dictionary<float, string[]>();

        EnemyData.Add(2f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(2.2f, new string[]
        {
            "Name:Enemy01_0,InitX:-1,MoveTargetY:4.5",
            "Name:Enemy01_0,InitX:0,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(2.6f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(2.65f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(2.7f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(2.75f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
            "Name:Enemy09,InitX:-2.7",
        });
        EnemyData.Add(2.8f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(2.85f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(3f, new string[]
        {
            "Name:Enemy06,InitX:3",
        });
        EnemyData.Add(3.2f, new string[]
        {
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(3.3f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:4",
        });
        EnemyData.Add(3.5f, new string[]
        {
            "Name:Enemy16,InitX:1",
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(3.7f, new string[]
        {
            "Name:Enemy09,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(3.95f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(4f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(4.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(4.5f, new string[]
        {
            "Name:Enemy16,InitX:3.15",
            "Name:Enemy04,InitX:-3.15,MoveTargetY:5.5",
        });
        EnemyData.Add(4.7f, new string[]
        {
            "Name:Enemy06,InitX:2.5,MoveTime:2",
        });
        EnemyData.Add(4.75f, new string[]
        {
            "Name:EnemyOther7,InitX:-2.15,MoveTargetY:5",
        });
        EnemyData.Add(4.9f, new string[]
        {
            "Name:Enemy05,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(5f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
            
        });
        EnemyData.Add(5.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(5.1f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(5.15f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(5.2f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(5.25f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(5.3f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
            "Name:EnemyOther7,InitX:3,MoveTargetY:5",
        });
        EnemyData.Add(5.5f, new string[]
        {
            "Name:Enemy09,InitX:1,MoveTargetY:4",
        });
        EnemyData.Add(5.8f, new string[]
        {
            "Name:Enemy06,InitX:0,MoveTime:2",
        });
        EnemyData.Add(6f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(6.2f, new string[]
        {
            "Name:Enemy09,InitX:-2.5,MoveTargetY:4.5",
        });
        EnemyData.Add(6.5f, new string[]
        {
            "Name:Enemy01_0,InitX:-1,MoveTargetY:4",
            "Name:Enemy01_1,InitX:-1.5,MoveTargetY:4",
            "Name:Enemy01_0,InitX:-2,MoveTargetY:4",
        });
        EnemyData.Add(7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(7.6f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(7.65f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(7.7f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(7.75f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
            "Name:Enemy05,InitX:-2.7,MoveTargetY:5.2",
        });
        EnemyData.Add(7.8f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(7.85f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(7.9f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
            "Name:Enemy04,InitX:2.8,MoveTargetY:5.2",
        });
        EnemyData.Add(8.1f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(8.15f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(8.2f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(8.5f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.55f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.6f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.65f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.75f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.8f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(9f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(9.2f, new string[]
        {
            "Name:Enemy01_0,InitX:-1,MoveTargetY:4.5",
            "Name:Enemy01_0,InitX:0,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(9.6f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(9.65f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(9.7f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(9.75f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
            "Name:Enemy09,InitX:-2.7",
        });
        EnemyData.Add(9.8f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(9.85f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(10f, new string[]
        {
            "Name:Enemy06,InitX:3",
        });
        EnemyData.Add(10.2f, new string[]
        {
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(10.3f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:4",
        });
        EnemyData.Add(10.5f, new string[]
        {
            "Name:Enemy16,InitX:1",
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(10.7f, new string[]
        {
            "Name:Enemy09,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(10.95f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(11f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(11.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(11.5f, new string[]
        {
            "Name:Enemy16,InitX:3.15",
            "Name:Enemy04,InitX:-3.15,MoveTargetY:5.5",
        });
        EnemyData.Add(11.7f, new string[]
        {
            "Name:Enemy06,InitX:2.5,MoveTime:2",
        });
        EnemyData.Add(11.75f, new string[]
        {
            "Name:EnemyOther7,InitX:-2.15,MoveTargetY:5",
        });
        EnemyData.Add(11.9f, new string[]
        {
            "Name:Enemy05,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(12f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",

        });
        EnemyData.Add(12.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(12.1f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(12.15f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(12.2f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(12.25f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(12.3f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
            "Name:EnemyOther7,InitX:3,MoveTargetY:5",
        });
        EnemyData.Add(12.5f, new string[]
        {
            "Name:Enemy09,InitX:1,MoveTargetY:4",
        });
        EnemyData.Add(12.8f, new string[]
        {
            "Name:Enemy06,InitX:0,MoveTime:2",
        });
        EnemyData.Add(13f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(13.2f, new string[]
        {
            "Name:Enemy09,InitX:-2.5,MoveTargetY:4.5",
        });
        EnemyData.Add(13.5f, new string[]
        {
            "Name:Enemy01_0,InitX:-1,MoveTargetY:4",
            "Name:Enemy01_1,InitX:-1.5,MoveTargetY:4",
            "Name:Enemy01_0,InitX:-2,MoveTargetY:4",
        });
        EnemyData.Add(14f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(14.6f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(14.65f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(14.7f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(14.75f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
            "Name:Enemy05,InitX:-2.7,MoveTargetY:5.2",
        });
        EnemyData.Add(14.8f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(14.85f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(14.9f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
            "Name:Enemy04,InitX:2.8,MoveTargetY:5.2",
        });
        EnemyData.Add(15.1f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(15.15f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(15.2f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(15.5f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(15.55f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(15.6f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(15.65f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(15.7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(15.75f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(15.8f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });









        EnemyData.Add(16f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(16.2f, new string[]
        {
            "Name:Enemy01_0,InitX:-1,MoveTargetY:4.5",
            "Name:Enemy01_0,InitX:0,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(16.6f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(16.65f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(16.7f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(16.75f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
            "Name:Enemy09,InitX:-2.7",
        });
        EnemyData.Add(16.8f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(16.85f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(17f, new string[]
        {
            "Name:Enemy06,InitX:3",
        });
        EnemyData.Add(17.2f, new string[]
        {
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(17.3f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:4",
        });
        EnemyData.Add(17.5f, new string[]
        {
            "Name:Enemy16,InitX:1",
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(17.7f, new string[]
        {
            "Name:Enemy09,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(17.95f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(18f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(18.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(18.5f, new string[]
        {
            "Name:Enemy16,InitX:3.15",
            "Name:Enemy04,InitX:-3.15,MoveTargetY:5.5",
        });
        EnemyData.Add(18.7f, new string[]
        {
            "Name:Enemy06,InitX:2.5,MoveTime:2",
        });
        EnemyData.Add(18.75f, new string[]
        {
            "Name:EnemyOther7,InitX:-2.15,MoveTargetY:5",
        });
        EnemyData.Add(18.9f, new string[]
        {
            "Name:Enemy05,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(19f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",

        });
        EnemyData.Add(19.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(19.1f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(19.15f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(19.2f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(19.25f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(19.3f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
            "Name:EnemyOther7,InitX:3,MoveTargetY:5",
        });
        EnemyData.Add(19.5f, new string[]
        {
            "Name:Enemy09,InitX:1,MoveTargetY:4",
        });
        EnemyData.Add(19.8f, new string[]
        {
            "Name:Enemy06,InitX:0,MoveTime:2",
        });
        EnemyData.Add(20f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(21.2f, new string[]
        {
            "Name:Enemy09,InitX:-2.5,MoveTargetY:4.5",
        });
        EnemyData.Add(24.5f, new string[] { "IsBoss:1" });
        EnemyData.Add(27f, new string[] { "Name:Enemy24,InitX:0" });
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        EnemyData.Clear();
    }
}
