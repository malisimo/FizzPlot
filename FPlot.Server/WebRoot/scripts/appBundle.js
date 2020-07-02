function initApp()
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

function initElement(el, parentId)
{
    switch (el.type)
    {
        case "Title":
            initTitleElement(el, parentId);
            break;
        case "TextBlock":
            initTextBlockElement(el, parentId);
            break;
        case "Chart":
            initChartElement(el, parentId);
            break;
    }
}

function initTitleElement(el, parentId)
{
    var titleHeader = document.createElement("h1");
    titleHeader.setAttribute("id", el.id);
    titleHeader.setAttribute("class", "title");
    titleHeader.innerHTML = el.text;
    document.getElementById(parentId).appendChild(titleHeader);
}

function initTextBlockElement(el, parentId)
{
    var textP = document.createElement("p");
    textP.setAttribute("id", el.id);
    textP.setAttribute("class", "textBlock");
    textP.innerHTML = el.text;
    document.getElementById(parentId).appendChild(textP);
}

function initChartElement(el, parentId)
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

function addChartSeries(chart, seriesObj)
{
    chart.addSeries(seriesObj);
}

function updateChartElement(chart, target, targetIndex, chartObj)
{
    if (target) {
        if (targetIndex >= 0) {
            chart[target][targetIndex].update(chartObj);
        } else {
            chart[target].update(chartObj);
        }
    } else {
        chart.update(chartObj);
    }
}

function createNewChart(chartId) {
    let myChart = {
        title: { text: 'Example plot' },
        yAxis: { title: { text: 'Value' } },
        xAxis: { title: { text: 'Index' } },
        legend: { layout: 'vertical', align: 'right', verticalAlign: 'middle' },
        series: [
            { name: 'A', data: [1.2, 1.4, 0.8, 0.6, 0.95, 0.35, 0.6, 0.25] },
            { name: 'B', data: [0.1, 0.25, 0.2, 0.5, 0.4, 0.8, 1.35, 1.1] },
            { name: 'C', data: [0.8, 0.7, 0.45, 1.15, 0.5, 0.85, 0.65, 0.75] }
        ]
    };

    return initChartElement({ id: chartId, highCharts: myChart }, "chartContainer");
}

function openWebSocket(appData) {
    var socket = new WebSocket('ws://localhost:5000/ws')
    socket.onopen = function () {
        //console.log('INFO: WebSocket opened successfully');
    }
    socket.onclose = function (event) {
        //console.log('INFO: WebSocket closed');
        console.info('WebSocket closed');
        console.log(event);
        openWebSocket(appData);
    }
    socket.onerror = function (error) {
        console.error('WebSocket error');
        console.log(error);
    }
    socket.onmessage = function (messageEvent) {
        console.info('Got websocket message');
        messageObj = JSON.parse(messageEvent.data);
        console.log(messageObj);

        switch (messageObj.operation) {
            case 'create':
                console.info('Adding new chart');
                appData.charts.unshift(initChartElement({ id: 'chart_' + appData.charts.length.toString(), highCharts: JSON.parse(messageObj.json) }, "chartContainer"));
                break;
            case 'add':
                if (appData.charts.length == 0) {
                    console.info('Adding new chart');
                    appData.charts.unshift(createNewChart('chart_' + appData.charts.length.toString()));
                }

                console.info('Adding series to chart');
                addChartSeries(appData.charts[messageObj.chartIndex], JSON.parse(messageObj.json));
                break;
            case 'update':
                console.info('Updating chart');
                updateChartElement(appData.charts[messageObj.chartIndex], messageObj.target, messageObj.targetIndex, JSON.parse(messageObj.json));
                break;
            case 'delete':
                console.info('Deleting chart or series');                    
                break;
            case 'fetch':
                if (appData.charts.length > messageObj.chartIndex) {
                    console.info('Fetching chart data');
                    socket.send(JSON.stringify(appData.charts[messageObj.chartIndex].userOptions));
                }
                else {
                    console.warn('Failed to fetch chart obj (no charts)');
                    socket.send("{}");
                }                 
                break;
        }
    }

    appData.socket = socket;
}
