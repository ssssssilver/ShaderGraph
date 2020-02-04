# ShaderGraph
个人shadergraph案例
  
1.计时着色器  
a.利用time函数对uv的offset进行缩放 产生的值作为shadergraph自带的噪波图uv，最终的结果作为计时的波浪效果    
b.使用ellpise函数创建计时显示的圆盘    
c.使用变量_Time来控制显示计时的百分比，值从0-1对应圆盘显示的空到满  
d. 利用Step函数对_Time变量进行01判断，当_Time的值低于指定值时圆盘显示低值颜色  
![计时](https://github.com/ssssssilver/ShaderGraphs/blob/master/ShaderGraphs/preview/timing.gif)
  
2.lowpoly风格的波浪着色器1  
通过改变网格每个顶点的z轴方向来实现 同时使用噪点图取样能实现波浪的不规则效果  
![波浪1](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/wave1.gif)  
  
3.lowpoly风格的波浪着色器2  
使用blender创建网格 分割网格的所有四边型后展开UV 并使所有网格的uv都缩放成一个点(scale=0）最后向上挤出网格  
![blender图](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/wave2.jpg)    
将模型导出fbx并导入到unity中 直接赋与1的着色器 由于网格每一个四边型的uv都挤成了一个点 所以波浪变成每个四边形上下改变位置  
![波浪2](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/wave2.gif)  
  
4.lowpoly网格的波浪着色器3  
通过uv与中心点的距离来绘制中心点 并与原本波浪着色器改变的顶点相加 可以制作上凸或者下陷效果  
![波浪3](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/wave3.gif)  
  
 5.龙卷风着色器
 a.首先需要在blender中自定义模型，需要用到uv_squares.py这个插件  
 创建的圆柱体需要右键平滑化 uv展开后需要调用uv_squares的to grid by shape，此操作可以所有网格的uv变得均匀分布  
 ![blender操作](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/tornado.jpg)    
 b.在unity中的呈现效果  
 ![龙卷风](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/tornado.gif) 
 图中的效果是由blender创建的同一个圆柱体叠放在一起 使用的都是同一个模型同一个着色器 但对每个模型的缩放跟着色器属性略有不同
 
