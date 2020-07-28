function genTheme(theme) {
    if (theme === 'dark') {
        return {
            colors: ['#DDDF0D', '#55BF3B', '#DF5353', '#7798BF', '#aaeeee',
                '#ff0066', '#eeaaee', '#55BF3B', '#DF5353', '#7798BF', '#aaeeee'],
            chart: {
                backgroundColor: {
                    linearGradient: { x1: 0, y1: 0, x2: 1, y2: 1 },
                    stops: [
                        [0, 'rgb(48, 48, 66)'],
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
    } else if (theme === 'gray') {
        return {
            colors: ['#DDDF0D', '#7798BF', '#55BF3B', '#DF5353', '#aaeeee',
                '#ff0066', '#eeaaee', '#55BF3B', '#DF5353', '#7798BF', '#aaeeee'],
            chart: {
                backgroundColor: {
                    linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                    stops: [
                        [0, 'rgb(96, 96, 96)'],
                        [1, 'rgb(16, 16, 16)']
                    ]
                },
                borderWidth: 0,
                borderRadius: 0,
                plotBackgroundColor: null,
                plotShadow: false,
                plotBorderWidth: 0
            },
            title: {
                style: {
                    color: '#FFF',
                    font: '16px Lucida Grande, Lucida Sans Unicode,' +
                        ' Verdana, Arial, Helvetica, sans-serif'
                }
            },
            subtitle: {
                style: {
                    color: '#DDD',
                    font: '12px Lucida Grande, Lucida Sans Unicode,' +
                        ' Verdana, Arial, Helvetica, sans-serif'
                }
            },
            xAxis: {
                gridLineWidth: 0,
                lineColor: '#999',
                tickColor: '#999',
                labels: {
                    style: {
                        color: '#999',
                        fontWeight: 'bold'
                    }
                },
                title: {
                    style: {
                        color: '#AAA',
                        font: 'bold 12px Lucida Grande, Lucida Sans Unicode,' +
                            ' Verdana, Arial, Helvetica, sans-serif'
                    }
                }
            },
            yAxis: {
                alternateGridColor: null,
                minorTickInterval: null,
                gridLineColor: 'rgba(255, 255, 255, .1)',
                minorGridLineColor: 'rgba(255,255,255,0.07)',
                lineWidth: 0,
                tickWidth: 0,
                labels: {
                    style: {
                        color: '#999',
                        fontWeight: 'bold'
                    }
                },
                title: {
                    style: {
                        color: '#AAA',
                        font: 'bold 12px Lucida Grande, Lucida Sans Unicode,' +
                            ' Verdana, Arial, Helvetica, sans-serif'
                    }
                }
            },
            legend: {
                backgroundColor: 'rgba(48, 48, 48, 0.8)',
                itemStyle: {
                    color: '#CCC'
                },
                itemHoverStyle: {
                    color: '#FFF'
                },
                itemHiddenStyle: {
                    color: '#333'
                },
                title: {
                    style: {
                        color: '#E0E0E0'
                    }
                }
            },
            labels: {
                style: {
                    color: '#CCC'
                }
            },
            tooltip: {
                backgroundColor: {
                    linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                    stops: [
                        [0, 'rgba(96, 96, 96, .8)'],
                        [1, 'rgba(16, 16, 16, .8)']
                    ]
                },
                borderWidth: 0,
                style: {
                    color: '#FFF'
                }
            },
            plotOptions: {
                series: {
                    dataLabels: {
                        color: '#444'
                    },
                    nullColor: '#444444'
                },
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
            toolbar: {
                itemStyle: {
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
    } else {
        return {
            colors: [
                '#5f98cf',
                '#434348',
                '#49a65e',
                '#f45b5b',
                '#708090',
                '#b68c51',
                '#397550',
                '#c0493d',
                '#4f4a7a',
                '#b381b3'
            ],
            navigator: {
                series: {
                    color: '#5f98cf',
                    lineColor: '#5f98cf'
                }
            }
        };
    }
}

function initApp() {
    Highcharts.setOptions(genTheme('dark'));
}

function initChartElement(el, parentId) {
    var element = document.getElementById(el.id);

    if (typeof(element) == 'undefined' || element == null) {
        var chartDiv = document.createElement("div");
        chartDiv.setAttribute("id", el.id);
        chartDiv.setAttribute("class", "chart");
        document.getElementById(parentId).appendChild(chartDiv);
    }

    return Highcharts.chart(el.id, el.highCharts);
}

function addChartSeries(chart, seriesObj) {
    chart.addSeries(seriesObj);
}

function updateChartElement(chart, target, chartObj) {
    if (target) {
        var co = _.cloneDeep(chart.options);
        _.set(co, target, chartObj);
        chart.update(co);
    } else {
        chart.update(chartObj);
    }

    chart.reflow();
}

function createNewChart(chartId) {
    let myChart = {
        title: { text: 'Plot' },
        yAxis: { title: { text: 'Value' } },
        xAxis: { title: { text: 'Index' } },
        legend: { layout: 'vertical', align: 'right', verticalAlign: 'middle' }
    };

    return initChartElement({ id: chartId, highCharts: myChart }, "chartContainer");
}

function openWebSocket(appData) {
    var socket = new WebSocket('ws://localhost:2387/ws')
    socket.onopen = function () {
        console.info('WebSocket opened successfully');
    }
    socket.onclose = function (event) {
        console.info('WebSocket closed');
        openWebSocket(appData);
    }
    socket.onerror = function (error) {
        console.error('WebSocket error');
        console.log(error);
    }
    socket.onmessage = function (messageEvent) {
        console.info('Got websocket message');
        messageObj = JSON.parse(messageEvent.data);
        //console.log(messageObj);

        switch (messageObj.operation) {
            case 'create':
                console.info('Adding new chart');
                appData.maxChartId+= 1;
                appData.charts.unshift(initChartElement({ id: 'chart_' + appData.maxChartId.toString(), highCharts: JSON.parse(messageObj.json) }, "chartContainer"));
                break;
            case 'add':
                if (appData.charts.length == 0) {
                    console.info('Adding new chart');
                    appData.maxChartId+= 1;
                    appData.charts.unshift(createNewChart('chart_' + appData.maxChartId.toString()));
                }
                if (appData.charts.length > messageObj.chartIndex) {
                    console.info('Adding series to chart');
                let seriesObj = JSON.parse(messageObj.json);
                    addChartSeries(appData.charts[messageObj.chartIndex], seriesObj);
                } else {
                    console.warn('Failed to add series (chart index out of range)');
                }
                break;
            case 'update':
                if (appData.charts.length > messageObj.chartIndex) {
                    console.info('Updating chart');
                    let msgObj = JSON.parse(messageObj.json);
                    updateChartElement(appData.charts[messageObj.chartIndex], messageObj.target, msgObj);
                } else {
                    console.warn('Failed to update chart (chart index out of range)');
                }
                break;
            case 'theme':
                if (appData.charts.length > messageObj.chartIndex) {
                    console.info('Updating chart');
                    var chartProps = _.cloneDeep(appData.charts[messageObj.chartIndex].options);
                    let theme = genTheme(JSON.parse(messageObj.json));
                    updateChartElement(appData.charts[messageObj.chartIndex], "", { ...chartProps, ...theme });
                } else {
                    console.warn('Failed to change theme (chart index out of range)');
                }
                break;
            case 'delete':
                console.info('Deleting chart or series');
                break;
            case 'fetch':
                if (appData.charts.length > messageObj.chartIndex) {
                    console.info('Fetching chart data');
                    var chartProps = _.cloneDeep(appData.charts[messageObj.chartIndex].options);
                    var seriesProps = appData.charts[messageObj.chartIndex].series.map(function (s) {
                        return _.cloneDeep(s.options);
                      });
                    chartProps.series = seriesProps;
                    chartProps.exporting.sourceWidth = appData.charts[messageObj.chartIndex].chartWidth;
                    chartProps.exporting.sourceHeight = appData.charts[messageObj.chartIndex].chartHeight;

                    socket.send(JSON.stringify(chartProps));
                } else {
                    console.warn('Failed to fetch chart props (chart index out of range)');
                    socket.send("{}");
                }
                break;
            case 'restore':
                if (appData.charts.length > messageObj.chartIndex) {
                    console.info('Restoring chart');
                    updateChartElement(appData.charts[messageObj.chartIndex], messageObj.target, msgObj);
                } else {
                    console.warn('Failed to restore chart (chart index out of range)');
                }                 
                break;
        }
    }

    appData.socket = socket;
}
