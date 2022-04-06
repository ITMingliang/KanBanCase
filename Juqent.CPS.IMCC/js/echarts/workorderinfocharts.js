function char4() {
    return {
        title: {
            text: "外壳打码",
            textStyle: {
                show: true,
                fontFamily: 'FZQiangKTJW_Zhong',
                color: '#07fff4',
                fontSize: 18,
                textShadow: '0 0vw 2vw #d6fff5',
            },
            padding:15,
        },
        grid: {
            top: "25%",
            left: "20%",
            bottom: "10%"
        },
        tooltip: {
            trigger: "axis",
            axisPointer: {
                type: "shadow",
                label: {
                    show: true
                }
            }
        },
        legend: {
            show: false,
        },
        xAxis: {
            data: [
                "6日",
                "7日",
                "8日",
                "9日",
                "10日",

            ],
            axisLine: {
                show: true //隐藏X轴轴线
            },
            axisTick: {
                show: true //隐藏X轴刻度
            },
            axisLabel: {
                show: true,
                textStyle: {
                    color: "#fff" //X轴文字颜色
                }
            },
            axisLine: {
                lineStyle: {
                    color: '#fff'
                }
            },
        },
        yAxis: [{
            type: "value",
            name: "pcs",
            nameTextStyle: {
                color: "#fff"
            },
            splitLine: {
                show: false
            },
            splitLine: {
                show: false
            },
            axisTick: {
                show: true
            },
            axisLine: {
                show: true
            },
            axisLabel: {
                show: true,
                textStyle: {
                    color: "#fff"
                }
            },
            axisLine: {
                lineStyle: {
                    color: '#FFFFFF'
                }
            },
        },
        {
            type: "value",
            name: "同比",
            position: "right",
            splitLine: {
                show: false
            },
            splitLine: {
                show: false
            },
            axisTick: {
                show: false
            },
            axisLine: {
                show: false
            },
            axisLabel: {
                show: false,
            }
        },
        {
            type: "value",
            gridIndex: 0,
            min: 50,
            max: 100,
            splitNumber: 12,
            splitLine: {
                show: false
            },
            axisLine: {
                show: false
            },
            axisTick: {
                show: false
            },
            axisLabel: {
                show: false
            },
            splitArea: {
                show: true,
                areaStyle: {
                    color: ["rgba(250,250,250,0.0)", "rgba(250,250,250,0.05)"]
                }
            }
        }
        ],
        series: [{
            name: "同比",
            type: "line",
            yAxisIndex: 1, //使用的 y 轴的 index，在单个图表实例中存在多个 y轴的时候有用
            smooth: true, //平滑曲线显示
            showAllSymbol: true, //显示所有图形。
            symbol: "circle", //标记的图形为实心圆
            symbolSize: 10, //标记的大小
            itemStyle: {
                normal: {
                    //折线拐点标志的样式
                    color: "#058cff"
                }
            },
            lineStyle: {
                normal: {
                    color: "#058cff"
                }
            },
            areaStyle: {
                color: "rgba(5,140,255, 0.2)"
            },
            label: {
                normal: {
                    show: true,
                    position: 'top'
                }
            },
            data: [3300, 3500, 2750, 3000, 1350]
        },
        {
            name: "产出",
            type: "bar",
            barWidth: 15,
            itemStyle: {
                normal: {
                    color: new echarts.graphic.LinearGradient(0, 0, 0, 1, [{
                        offset: 0,
                        color: "#00FFE3"
                    },
                    {
                        offset: 1,
                        color: "#4693EC"
                    }
                    ])
                }
            },
            data: [3300, 3500, 2750, 3000, 1350]
        }
        ]
    };
}

function char5() {
    return {
        tooltip: {
            trigger: 'axis',
            backgroundColor: 'rgba(255,255,255,0.1)',
            axisPointer: {
                type: 'shadow',
                label: {
                    show: true,
                    backgroundColor: '#7B7DDC'
                }
            }
        },
        legend: {
            data: ['计划产量', '实际产量'],
            textStyle: {
                color: '#fff'
            },
            top: '7%',
        },
        grid: {
            top: '25%',
            left: '10%',
            bottom: '10%',
        },
        xAxis: {
            //data: ["7:00", "8:30", "9:00", "10:30", "11:30", "12:00", "13:30", "14:30", "15:30", "16:30", "17:30", "18:30", ""],
            data: ["7:00",  "9:00", "11:00", "13:00", "15:00", "17:00", "19:00", "21:00"],
            axisLine: {
                lineStyle: {
                    color: '#B4B4B4'
                }
            },
            axisTick: {
                show: false,
            },
            axisLabel: {                                      
                color: "#fff",
                fonSize: 5,
                rotate:30,
            }
        },
        yAxis: [{
            splitLine: { show: false },
            axisLine: {
                lineStyle: {
                    color: '#B4B4B4',
                }
            },

            axisLabel: {
                formatter: '{value} ',
                color: "#fff",
                fontSize:12
            }
        },     
        ],
        series: [
        {
            name: '实际产量',
            type: 'bar',
            barWidth: 12,
                itemStyle: {
                    normal: {
                        barBorderRadius: 30,
                        color: new echarts.graphic.LinearGradient(0, 0, 0, 1, [{
                            offset: 0,
                            color: "rgba(0, 244, 255, 1)"
                        },
                        {
                            offset: 1,
                            color: "rgba(0,77,167,1)"
                        }
                        ])
                    }
                },
            label: {
                normal: {
                    show: true
                }
            },
            //data: [126,128,124,128,124,128,128,128,128,120,130,120,123]
                data: [126, 128, 124, 128, 124, 128, 128, 128],
        },

        {
            name: '计划产量',
            type: 'line',
            smooth:'true',
            symbol: 'emptyCircle',
            symbolSize: 5,
            yAxisIndex: 0,
            itemStyle: {
                normal: {
                    color: "#058cff"
                },
            },
            label: {
                normal: {
                    show: true,
                    formatter: '{c}'
                }
            },
            //data: [130, 130, 130, 130, 130, 130, 130, 130, 130,130,130,130,130]
            data: [130, 130, 130, 130, 130, 130, 130, 130]
        },
        ]
    }
}

function char6() {
    return {
        tooltip: {
            trigger: 'axis',
            axisPointer: {
                lineStyle: {
                    color: '#57617B'
                }
            }
        },
        legend: {

            data: [
                { "name": "计划产量" },
                { "name": "实际产量" },
                { "name": "完成率" }
            ],
            top: "0%",
            textStyle: {
                "color": "rgba(255,255,255,0.9)"//图例文字
            }
        },

        xAxis: [
            {
                type: "category",

                data: ["7:00", "8:30", "9:00", "10:30", "11:30", "12:00", "13:30", "14:30", "15:30", "16:30", "17:30", "18:30","19:30"],
                axisLine: { lineStyle: { color: "rgba(255,255,255,.1)" } },
                axisLabel: {
                    textStyle: { color: "rgba(255,255,255,.6)", fontSize: '14', },
                },

            },
        ],
        yAxis: [
            {
                type: "value",
                name: "产量",
                //"min": 0,
                //"max": 50,
                //"interval": 10,
                axisLabel: {
                    show: true,

                },
                axisLine: { lineStyle: { color: 'rgba(255,255,255,.4)' } },//左线色

            },
            {
                type: "value",
                name: "完成率",
                show: true,
                axisLabel: {
                    "show": true,

                },
                axisLine: { lineStyle: { color: 'rgba(255,255,255,.4)' } },//右线色
                splitLine: { show: true, lineStyle: { color: "#001e94" } },//x轴线
            },
        ],
        grid: {
            //top: "10%",
            //right: "30",
            bottom: "15%",
            left: "10%",
        },
        series: [
            {
                name: "计划产量",

                type: "bar",
                data: [130, 130, 130, 130, 130, 130, 130, 130, 130, 130, 130, 130, 130],
                barWidth: 8,
                itemStyle: {
                    normal: {
                        color: {
                            type: "linear",
                            x: 0,
                            y: 0,
                            x2: 0,
                            y2: 1,
                            colorStops: [
                                {
                                    offset: 0,
                                    color: "#609db8"
                                },

                                {
                                    offset: 1,
                                    color: "#609db8"
                                }
                            ],
                            globalCoord: false
                        }
                    }
                },
                label: {
                    normal: {
                        show: true,
                        position: 'top',
                        fontSize: 8

                    }
                }
            },
            {
                name: "实际产量",
                type: "bar",
                data: [126, 128, 124, 128, 124, 128, 128, 128, 128, 120, 130, 120, 123],
                barWidth:8,
                itemStyle: {
                    normal: {
                        color: {
                            type: "linear",
                            x: 0,
                            y: 0,
                            x2: 0,
                            y2: 1,
                            colorStops: [
                                {
                                    offset: 0,
                                    color: "#66b8a7"
                                },
                                {
                                    offset: 1,
                                    color: "#66b8a7"
                                }
                            ],
                            globalCoord: false
                        }
                    }
                },
                barGap: "0"
            },
            {
                name: "完成率",
                type: "line",
                yAxisIndex: 1,
                data: [100, 50, 80, 30, 90, 40, 70, 33, 100, 40, 80, 20,99],
                lineStyle: {
                    normal: {
                        width: 2
                    },
                },
                itemStyle: {
                    normal: {
                        color: "#cdba00",

                    }
                },
                label: {
                    normal: {
                        show: true,
                        position: 'top',
                        fontSize: 8

                    }
                },
                smooth: true
            }
        ]
    };
}

function char7() {
    return {
        title: {
            text: '外壳打码',
            textStyle: {
                //color: '#07fff4',
                color:'#fff',
                fontSize: 18,
                fontFamily: 'sans-serif',
                fontWeight: 'bold',
                
            },
            padding: 15,            
        },
        tooltip: {
            trigger: 'axis',
            axisPointer: {
                lineStyle: {
                    color: {
                        type: 'linear',
                        x: 0,
                        y: 0,
                        x2: 0,
                        y2: 1,
                        colorStops: [{
                            offset: 0,
                            color: 'rgba(255,255,255,0)' // 0% 处的颜色
                        }, {
                            offset: 0.5,
                            color: 'rgba(255,255,255,1)' // 100% 处的颜色
                        }, {
                            offset: 1,
                            color: 'rgba(255,255,255,0)' // 100% 处的颜色
                        }],
                        global: false // 缺省为 false
                    }
                },
            },

        },
        grid: {
            top: "25%",
            left: "20%",
            bottom: "10%"
        },
        xAxis: [{
            type: 'category',
            boundaryGap: true,
            axisLine: { //坐标轴轴线相关设置。数学上的x轴
                show: true,
                lineStyle: {
                    color: 'rgba(255,255,255,0.4)'
                },
            },
            axisLabel: { //坐标轴刻度标签的相关设置
                textStyle: {
                    color: '#d1e6eb',
                    margin: 15,
                },
            },
            axisTick: {
                show: false,
            },
            data: ["6日","7日","8日","9日","10日"],
        }],
        yAxis: [{
            type: 'value',
            min: 0,
            // max: 140,
            splitNumber: 4,
            splitLine: {
                show: true,
                lineStyle: {
                    color: 'rgba(255,255,255,0.1)'
                }
            },            
            axisLine: { lineStyle: { color: 'rgba(255,255,255,.4)' } },//左线色
            axisLabel: {
                show: true,
                margin: 20,
                textStyle: {
                    color: '#d1e6eb',

                },
            },
            axisTick: {
                show: true,
            },
        }],
        series: [{
            name: 'pcs',
            type: 'line',
            label: {
                normal: {
                    show: true,
                    position: 'top',
                    textStyle: {
                        color: '#fff',
                    }
                }
            },           
            // smooth: true, //是否平滑曲线显示
            // 			symbol:'circle',  // 默认是空心圆（中间是白色的），改成实心圆
            showAllSymbol: true,
            // symbol: 'image://./static/images/guang-circle.png',
            symbolSize: 6,
            lineStyle: {
                normal: {
                    color: "#53fdfe", // 线条颜色
                },
                borderColor: '#f0f'
            },
            itemStyle: {
                normal: {
                    color: "rgba(255,255,255,1)",
                }
            },
            tooltip: {
                show: true
            },
            areaStyle: { //区域填充样式
                normal: {
                    //线性渐变，前4个参数分别是x0,y0,x2,y2(范围0~1);相当于图形包围盒中的百分比。如果最后一个参数是‘true’，则该四个值是绝对像素位置。
                    color: new echarts.graphic.LinearGradient(0, 0, 0, 1, [{
                        offset: 0,
                        color: 'rgba(0,150,239,0.3)'
                    },
                    {
                        offset: 1,
                        color: 'rgba(0,253,252,0)'
                    }
                    ], false),
                    shadowColor: 'rgba(53,142,215, 0.9)', //阴影颜色
                    shadowBlur: 20 //shadowBlur设图形阴影的模糊大小。配合shadowColor,shadowOffsetX/Y, 设置图形的阴影效果。
                }
            },
            markLine: {
                lineStyle: {
                    color: 'rgba(128, 128, 128, 0.5)',
                },                
                data: [
                    { type: 'average', name: '平均值' }
                ]
            },
            data: [3300, 3500, 2750, 3000, 1350]
        }]
    }
}

function char8() {
    return {
        title: {
            text: '异常信息',
            subtext: '前10项',
            left: 'left',
            top: '5%',
            textStyle: {
                color:'#fff',
            }
        },
        tooltip: {
            trigger: 'item',
            formatter: "{b} : {c}%"
        },
        toolbox: {
            orient: 'vertical',
            top: 'center',
            feature: {
                dataView: { readOnly: false },
                restore: {},
                saveAsImage: {}
            }
        },
        legend: {
            orient: 'vertical',
            left: '5%',
            top: '25%',
            textStyle: {
                color: '#fff',
            },
            data: ['异常1', '异常2', '异常3', '异常4', '异常5', '异常6', '异常7', '异常8', '异常9', '异常10']
        },
        calculable: true,
        series: [
            {
                name: '漏斗图',
                type: 'funnel',
                width: '40%',
                height: '75%',
                left: '35%',
                top: '25%',
                label: {
                    normal: {
                        position: 'center',
                        formatter: "{b} : {c}%"
                    }
                },
                data: [
                    { value: 60, name: '异常1' },
                    { value: 30, name: '异常2' },
                    { value: 10, name: '异常3' },
                    { value: 80, name: '异常4' },
                    { value: 100, name: '异常5' },
                    { value: 60, name: '异常6' },
                    { value: 30, name: '异常7' },
                    { value: 10, name: '异常8' },
                    { value: 80, name: '异常9' },
                    { value: 100, name: '异常10' }
                ]
            }
        ]
    };

}


var char9data = [{
    name: "正常运行",
    value: 89
},
{
    name: "异常运行",
    value: 21
},
{
    name: "故障中",
    value: 15
},
{
    name: "调试中",
    value: 5
}
];

var titleArr = [], seriesArr = [];
colors = [['#389af4', '#dfeaff'], ['#389af4', '#dfeaff'], ['#389af4', '#dfeaff'], ['#389af4', '#dfeaff'], ['#389af4', '#dfeaff']]
char9data.forEach(function (item, index) {
    titleArr.push(
        {
            text: item.name,
            left: index * 20 + 20 + '%',
            top: '85%',
            textAlign: 'center',
            textStyle: {
                fontWeight: 'normal',
                fontSize: '16',
                color: colors[index][0],
                textAlign: 'center',
            },
        }
    );
    seriesArr.push(
        {
            name: item.name,
            type: 'pie',
            clockWise: false,
            radius: [40, 48],
            itemStyle: {
                normal: {
                    color: colors[index][0],
                    shadowColor: colors[index][0],
                    shadowBlur: 0,
                    label: {
                        show: false
                    },
                    labelLine: {
                        show: false
                    },
                }
            },
            hoverAnimation: false,
            center: [index * 20 + 20 + '%', '50%'],           
            data: [{
                value: item.value,
                label: {
                    normal: {
                        formatter: function (params) {
                            return params.value + '%';
                        },
                        position: 'center',
                        show: true,
                        textStyle: {
                            fontSize: '20',
                            fontWeight: 'bold',
                            color: colors[index][0]
                        }
                    }
                },
            }, {
                value: 100 - item.value,
                name: 'invisible',
                itemStyle: {
                    normal: {
                        color: colors[index][1]
                    },
                    emphasis: {
                        color: colors[index][1]
                    }
                }
            }]
        }
    )
});

function char9() {
    return {
        title: titleArr,       
        series: seriesArr
    };
}

function char10() {
    return {
        title: {
            text: '外壳打码',
            textStyle: {
                //color: '#07fff4',
                color: '#fff',
                fontSize: 18,
                fontFamily: 'sans-serif',
                fontWeight: 'bold',

            },
            padding: 15,
        },
        tooltip: {
            trigger: 'axis',
            axisPointer: {
                lineStyle: {
                    color: {
                        type: 'linear',
                        x: 0,
                        y: 0,
                        x2: 0,
                        y2: 1,
                        colorStops: [{
                            offset: 0,
                            color: 'rgba(255,255,255,0)' // 0% 处的颜色
                        }, {
                            offset: 0.5,
                            color: 'rgba(255,255,255,1)' // 100% 处的颜色
                        }, {
                            offset: 1,
                            color: 'rgba(255,255,255,0)' // 100% 处的颜色
                        }],
                        global: false // 缺省为 false
                    }
                },
            },

        },
        grid: {
            top: "25%",
            left: "20%",
            bottom: "10%"
        },
        xAxis: [{
            type: 'category',
            boundaryGap: true,
            axisLine: { //坐标轴轴线相关设置。数学上的x轴
                show: true,
                lineStyle: {
                    color: 'rgba(255,255,255,0.4)'
                },
            },
            axisLabel: { //坐标轴刻度标签的相关设置
                textStyle: {
                    color: '#fff',
                    margin: 15,
                },
            },
            axisTick: {
                show: false,
            },
            data: ["6日", "7日", "8日", "9日", "10日"],
        }],
        yAxis: [{
            type: 'value',
            min: 0,
            // max: 140,
            splitNumber: 4,
            splitLine: {
                show: true,
                lineStyle: {
                    color: 'rgba(255,255,255,0.1)'
                }
            },
            axisLine: { lineStyle: { color: 'rgba(255,255,255,.4)' } },//左线色
            axisLabel: {
                show: true,
                margin: 20,
                textStyle: {
                    color: '#fff',

                },
            },
            axisTick: {
                show: true,
            },
        }],
        series: [
            {
                name: '2016',
                type: 'bar',
                barWidth: 12,
                itemStyle: {
                    normal: {
                        color: new echarts.graphic.LinearGradient(
                            0, 0, 0, 1,
                            [
                                { offset: 1, color: '#956FD4' },
                                { offset: 0, color: '#3EACE5' }
                            ]
                        ),
                    }
                },
                label: {
                    normal: {
                        show: true,
                        //position: 'top',
                        color: "#fff",
                    }
                },
                //stack: '总量',
                markPoint: {
                    symbolSize:50,
                    data: [
                        { type: 'max', name: '最大值' },
                        { type: 'min', name: '最小值' }
                    ]
                },
                markLine: {
                    data: [
                        { type: 'average', name: '平均值' }
                    ],
                    label: {
                        normal: {
                            color:'#fff'
                        }
                    }
                },
                data: [1741.9, 977, 1742.2, 1431.1, 1636.2, 1447, 1711.7, 1921.2, 2609.6, 3332.6, 3647.3, 2498.1]
            },

        ]
    }
}