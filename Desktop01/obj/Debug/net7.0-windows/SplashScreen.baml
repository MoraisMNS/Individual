   M S B A M L   `   `   `  ����D  @Desktop01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Desktop01	Desktop01  5   	       Desktop01.SplashScreen   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Desktop01     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  SplashScreen��5	   	   $	��800��6   $	��800��6+    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	   
���   �.��5      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6      MaterialDesignPaper#���   63   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6f   $��25q�5      .��5   
   ��  �� CornerRadius$ 25 25 25 25��6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��120.8 �6#   5      �� 5      $��529.2 �6#   �� 5      $	��400 �6#   61   .+�5      �� $��0��6   $
��Left=�6)   $��Center=�5      $��50,0,0,0q�64   $	��388��6F   $	��590��6S   $��2��6_   .+�5      �� .+�5       �  � Points' �    e� �� '�) �� F�# �����	#FF7400BA$
��Left=�6P   	 �� Left$	 23��6k   $	��Top=�6|   

 �� Top$

 -246��6�   � 5$      ' �    �� �� F�# �� e� F�#���	#FF62039B$
��Left=�6P   $

 -246��6k   $	��Top=�6}   $		 150��6�   � 5&      ' �    �� �� �� �� �� �����	#809A24F9$
��Left=�6P   $	��Top=�6k   $	��300��6�   $		 150��6�   $

 -341��6�   � 5(      ' �    F�# �� �/ �� '�) ��$
��Left=�6@   $

 -246��6[   $	��Top=�6m   ���	#FF7009CF$	 50��6�   $	��743��6�   � 5*      ' �    �� �� e� �� �� e����	#80490B51$		 140��6P   $	
 -46��6b   $
��Left=�6s   $	��Top=�6�   � 5,      ' �    '�) �� �5 �� �/ F�#���	#8049055E$	 10��6P   $

 -246��6a   $
��Left=�6s   $	��Top=�6�   $	��868��6�   $	��555��6�   � 5.      ' �    �� �� F�# �� e� �����	#80451656$

 -200��6P   $
��Left=�6b   $	��Top=�6}   � 50      ' �    e� �� '�) �� F�# F�#���	#80662EA3$		 150��6P   $
��Left=�6b   $	��Top=�6}   $	
 -36��6�   51      � 52      .+�53      �� $��0 60 0 5q�6   $	��100��60   55      �� 56      $ ��Student Management System ��6    $��35(�6B   $��	ExtraBold"�6P   
��� ���$	��564��6y   $
��Left=�57       $��Center=�6;   58      �� 59      $��Loading Resources.....��6   $��16(�6:   $��Heavy"�6H   
�������$
��Left=�5:      $��	0 30 0 15q�67   6L   �� 5=      $��MORAIS M.N.S.��6   $��16(�61   $��Heavy"�6?   
�������$
��Left=�5>      $��	0 30 0 15q�67   6L   �� 5?      $��EG/2020/4077��6   $��16(�60   $��Heavy"�6>   
�������$
��Left=�5@      $��	0 30 0 15q�67   6L   � 5A      -   5        $��progressBar��5A       � Value$ 0Q�61   $��5��6;   $	��548��6F    � IsIndeterminate$
 True��6S   5C      5E      5F      5H      5K      