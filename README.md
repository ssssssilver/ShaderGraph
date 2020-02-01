# ShaderGraph
个人shadergraph练习
  
1.计时着色器  
a.利用time函数对uv的offset进行缩放 产生的值作为shadergraph自带的噪波图uv，最终的结果作为计时的波浪效果
b.使用ellpise函数创建计时显示的圆盘
c.使用变量_Time来控制显示计时的百分比，值从0-1对应圆盘显示的空到满
d. 利用Step函数对_Time变量进行01判断，当_Time的值低于指定值时圆盘显示低值颜色
[计时](https://github.com/ssssssilver/ShaderGraphs/blob/master/ShaderGraphs/preview/timing.gif)
