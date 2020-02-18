# ShaderGraph
个人shadergraph案例  
  
 v_1.1   
开发环境 unity 2019.3  

因为想让工程发布到webGL 但查阅了很多资料后发现2018的版本并不兼容webGL 会出现黑屏的情况 所以将工程升级到了2019.3    
如果工程无法正常打开 可以尝试下删除assets文件夹同层级的除assets和projectsetting文件夹之外的所有文件，并将工程的packages下的依赖包都更新一次就好  
个别场景新增了post process 因为2019版本的unity新增了urp，默认是兼容lwrp 但需要手动设置才能兼容使用post process 
![urp](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/urp.jpg)  
  
版本新增内容  
1.新增操作功能  
增加wsad移动鼠标右键旋转视角功能  
增加GUI改变材质属性面板  
增加GUI快捷跳转场景按钮  

2.新增着色器  
计时着色器优化  
用2d的面板显示一个伪3d的计时球   
使用spherize方法把噪波图变得球体化 使用voronoi图模拟水面效果 并用lerp方法将两者混合  
![计时2](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/timing2.gif)  
  
漩涡着色器  
使用的面片需要用blender进行创建一个plane 给plane进行subdivide分成多个面并使用lattice功能将面片倒成一个圆再导出，如图  
![圆](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/whrispool.jpg)  
对圆的面片用Twirl方法进行旋转 把结果当成voronoi的uv 最后的输出再附加到顶点position上 
用自带的噪波图作为法线贴图 让漩涡产生起伏效果  
![漩涡](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/whrispool.gif)  

瀑布着色器  
瀑布的面片需要用blender制作 如图  
![瀑布](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/waterfall.jpg)  
对voronoi图进行uv操作 并映射到color上模拟水流下的效果 对面片顶点的z轴进行修改增强水流立体感  
![瀑布](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/waterfall.gif)  

火焰着色器  
将着色器应用到粒子系统上并用QUAD来代替原本的广告板效果 这样的话不管从哪个方向看向火焰都是朝向正面  
火焰使用voronoi来进行模拟（万能的voronoi） 对voronoi进行向上的uv偏移模拟火焰燃烧 用disance方法对voronoi进行遮罩作为alpha值 并且进行alphatest操作  使火焰产生镂空效果 并用使用插值方法分离出焰心与焰边分别着色  
![火焰](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/fire.gif)  
  
消融着色器
对模型空间下的y轴进行操作 将结果作用于alphaclip Threshold中 再将模型的alpha值设置成0.5 这样的alphatest操作能控制物体在模型空间下进行消溶
![消融](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/dissolve.gif)  

======================================================================================================  
v_1.0  
开发环境 unity 2018.4  

如果项目场景无法正常显示 需要自行在windows->package manager中添加Lightweight RP与shader graph包
  
计时着色器  
a.利用time函数对uv的offset进行缩放 产生的值作为shadergraph自带的噪波图uv，最终的结果作为计时的波浪效果    
b.使用ellpise函数创建计时显示的圆盘    
c.使用变量_Time来控制显示计时的百分比，值从0-1对应圆盘显示的空到满  
d. 利用Step函数对_Time变量进行01判断，当_Time的值低于指定值时圆盘显示低值颜色  
![计时](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/timing.gif)
  
lowpoly风格的波浪着色器1  
通过改变网格每个顶点的z轴方向来实现 同时使用噪点图取样能实现波浪的不规则效果  
![波浪1](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/wave1.gif)  
  
lowpoly风格的波浪着色器2  
使用blender创建网格 分割网格的所有四边型后展开UV 并使所有网格的uv都缩放成一个点(scale=0）最后向上挤出网格  
![blender图](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/wave2.jpg)    
将模型导出fbx并导入到unity中 直接赋与1的着色器 由于网格每一个四边型的uv都挤成了一个点 所以波浪变成每个四边形上下改变位置  
![波浪2](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/wave2.gif)  
  
lowpoly网格的波浪着色器3  
通过uv与中心点的距离来绘制中心点 并与原本波浪着色器改变的顶点相加 可以制作上凸或者下陷效果  
![波浪3](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/wave3.gif)  
  
 龙卷风着色器
 a.首先需要在blender中自定义模型，需要用到uv_squares.py这个插件  
 创建的圆柱体需要右键平滑化 uv展开后需要调用uv_squares的to grid by shape，此操作可以所有网格的uv变得均匀分布  
 ![blender操作](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/tornado.jpg)    
 b.在unity中的呈现效果  
 ![龙卷风](https://github.com/ssssssilver/ShaderGraph/blob/master/ShaderGraphs/preview/tornado.gif) 
 图中的效果是由blender创建的同一个圆柱体叠放在一起 使用的都是同一个模型同一个着色器 但对每个模型的缩放跟着色器属性略有不同
 
