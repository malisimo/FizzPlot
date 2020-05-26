function InitApp()
{
    Highcharts.theme = {
        colors: ['#DDDF0D', '#55BF3B', '#DF5353', '#7798BF', '#aaeeee',
            '#ff0066', '#eeaaee', '#55BF3B', '#DF5353', '#7798BF', '#aaeeee'],
        chart: {
            backgroundColor: {
                linearGradient: { x1: 0, y1: 0, x2: 1, y2: 1 },
                stops: [
                    [0, 'rgb(48, 48, 96)'],
                    [1, 'rgb(0, 0, 0)']
                ]
            },
            borderColor: '#000000',
            borderWidth: 2,
            className: 'dark-container',
            plotBackgroundColor: 'rgba(255, 255, 255, .1)',
            plotBorderColor: '#CCCCCC',
            plotBorderWidth: 1
        },
        title: {
            style: {
                color: '#C0C0C0',
                font: 'bold 16px "Trebuchet MS", Verdana, sans-serif'
            }
        },
        subtitle: {
            style: {
                color: '#666666',
                font: 'bold 12px "Trebuchet MS", Verdana, sans-serif'
            }
        },
        xAxis: {
            gridLineColor: '#333333',
            gridLineWidth: 1,
            labels: {
                style: {
                    color: '#A0A0A0'
                }
            },
            lineColor: '#A0A0A0',
            tickColor: '#A0A0A0',
            title: {
                style: {
                    color: '#CCC',
                    fontWeight: 'bold',
                    fontSize: '12px',
                    fontFamily: 'Trebuchet MS, Verdana, sans-serif'
                }
            }
        },
        yAxis: {
            gridLineColor: '#333333',
            labels: {
                style: {
                    color: '#A0A0A0'
                }
            },
            lineColor: '#A0A0A0',
            minorTickInterval: null,
            tickColor: '#A0A0A0',
            tickWidth: 1,
            title: {
                style: {
                    color: '#CCC',
                    fontWeight: 'bold',
                    fontSize: '12px',
                    fontFamily: 'Trebuchet MS, Verdana, sans-serif'
                }
            }
        },
        tooltip: {
            backgroundColor: 'rgba(0, 0, 0, 0.75)',
            style: {
                color: '#F0F0F0'
            }
        },
        toolbar: {
            itemStyle: {
                color: 'silver'
            }
        },
        plotOptions: {
            line: {
                dataLabels: {
                    color: '#CCC'
                },
                marker: {
                    lineColor: '#333'
                }
            },
            spline: {
                marker: {
                    lineColor: '#333'
                }
            },
            scatter: {
                marker: {
                    lineColor: '#333'
                }
            },
            candlestick: {
                lineColor: 'white'
            }
        },
        legend: {
            backgroundColor: 'rgba(0, 0, 0, 0.5)',
            itemStyle: {
                font: '9pt Trebuchet MS, Verdana, sans-serif',
                color: '#A0A0A0'
            },
            itemHoverStyle: {
                color: '#FFF'
            },
            itemHiddenStyle: {
                color: '#444'
            },
            title: {
                style: {
                    color: '#C0C0C0'
                }
            }
        },
        credits: {
            style: {
                color: '#666'
            }
        },
        labels: {
            style: {
                color: '#CCC'
            }
        },
        navigation: {
            buttonOptions: {
                symbolStroke: '#DDDDDD',
                theme: {
                    fill: {
                        linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                        stops: [
                            [0.4, '#606060'],
                            [0.6, '#333333']
                        ]
                    },
                    stroke: '#000000'
                }
            }
        },
        // scroll charts
        rangeSelector: {
            buttonTheme: {
                fill: {
                    linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                    stops: [
                        [0.4, '#888'],
                        [0.6, '#555']
                    ]
                },
                stroke: '#000000',
                style: {
                    color: '#CCC',
                    fontWeight: 'bold'
                },
                states: {
                    hover: {
                        fill: {
                            linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                            stops: [
                                [0.4, '#BBB'],
                                [0.6, '#888']
                            ]
                        },
                        stroke: '#000000',
                        style: {
                            color: 'white'
                        }
                    },
                    select: {
                        fill: {
                            linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                            stops: [
                                [0.1, '#000'],
                                [0.3, '#333']
                            ]
                        },
                        stroke: '#000000',
                        style: {
                            color: 'yellow'
                        }
                    }
                }
            },
            inputStyle: {
                backgroundColor: '#333',
                color: 'silver'
            },
            labelStyle: {
                color: 'silver'
            }
        },
        navigator: {
            handles: {
                backgroundColor: '#666',
                borderColor: '#AAA'
            },
            outlineColor: '#CCC',
            maskFill: 'rgba(16, 16, 16, 0.5)',
            series: {
                color: '#7798BF',
                lineColor: '#A6C7ED'
            }
        },
        scrollbar: {
            barBackgroundColor: {
                linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                stops: [
                    [0.4, '#888'],
                    [0.6, '#555']
                ]
            },
            barBorderColor: '#CCC',
            buttonArrowColor: '#CCC',
            buttonBackgroundColor: {
                linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                stops: [
                    [0.4, '#888'],
                    [0.6, '#555']
                ]
            },
            buttonBorderColor: '#CCC',
            rifleColor: '#FFF',
            trackBackgroundColor: {
                linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                stops: [
                    [0, '#000'],
                    [1, '#333']
                ]
            },
            trackBorderColor: '#666'
        }
    };
    // Apply the theme
    Highcharts.setOptions(Highcharts.theme);
}

function InitElement(el, parentId)
{
    switch (el.type)
    {
        case "Title":
            InitTitleElement(el, parentId);
            break;
        case "TextBlock":
            InitTextBlockElement(el, parentId);
            break;
        case "Chart":
            InitChartElement(el, parentId);
            break;
    }
}

function InitTitleElement(el, parentId)
{
    var titleHeader = document.createElement("h1");
    titleHeader.setAttribute("id", el.id);
    titleHeader.setAttribute("class", "title");
    titleHeader.innerHTML = el.text;
    document.getElementById(parentId).appendChild(titleHeader);
}

function InitTextBlockElement(el, parentId)
{
    var textP = document.createElement("p");
    textP.setAttribute("id", el.id);
    textP.setAttribute("class", "textBlock");
    textP.innerHTML = el.text;
    document.getElementById(parentId).appendChild(textP);
}

function InitChartElement(el, parentId)
{
    var element = document.getElementById(el.id);

    if (typeof(element) == 'undefined' || element == null) {
        var chartDiv = document.createElement("div");
        chartDiv.setAttribute("id", el.id);
        chartDiv.setAttribute("class", "chart");
        document.getElementById(parentId).appendChild(chartDiv);
    }

    return Highcharts.chart(el.id, el.highCharts);
}

function AddChartSeries(chart, seriesObj)
{
    chart.addSeries(seriesObj);
}

function UpdateChartElement(chart, chartObj)
{
    chart.update(chartObj);
}
