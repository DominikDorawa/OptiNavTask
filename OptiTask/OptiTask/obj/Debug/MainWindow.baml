   M S B A M L   `   `   `  ����C  ?OptiTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:OptiTaskOptiTask  5   	       OptiTask.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:OptiTask     5   	     � Title$  OptiTask��5   	   $	��600��6   $	��800��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      6%   �� 5      6%   .+�5      �� -   5        $
��load��5      
�������$��0��63   $	��150��5   -   $��80��69   $��20(�6E   $��	ExtraBold"�6S    �� 	ClickMode$ Press=�5   @   .��5   /   
Wgraj plik5      �� 5      -   5        $
��save��5      $	��150��64   $��80��6@   $��20(�6L   $��	ExtraBold"�6Z   $��1��6q   
�������.��6�   Zapisz5      5      � 5   
   $��1��6   .+�5      �� $	��Top=�6%   $
��Auto��5    %   $
��Auto��5!   %   $��Disabled=�5"   %   $
��Auto=�5#   %   .��5$      �� -   5         ��Name$ numbers1��5$       �� 
IsReadOnly .  �� TextWrapping$
 Wrap=�5%   C   $��15(�5&   1   $
��Bold"�5'   1   $
��Auto��5(   1   $	��150��5)   1   $��	20,0,20,0q�5*      
���������5$   ,   �� *NumbersString+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�5+   1   5,      5-      � 5.   
   $��2��6   .+�5/      �� $
��Auto��50      $	��160��51      $��Disabled=�52      $
��Auto=�53      $��
20,0,20,30q�54      $��Bottom=�6/   .��56      �� -   5        $ numbers2��56       . $
 Wrap=�57   C   $��15(�58   1   $
��Bold"�59   1   $
��Auto��5:   1   $	��150��5;   1   
���������56   ,   �� *NumbersString2+$ TwoWay=�$ PropertyChanged=�5<   1   5=      5>      5?      5@      