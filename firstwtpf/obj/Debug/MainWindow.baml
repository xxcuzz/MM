   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections  5   	   D @firstwtpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FirstWpfAppFirstWpfApp 5   	      FirstWpfApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FirstWpfApp     5   	     � WindowStyle$  
ToolWindow=�5	   	    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ Modern Museum��5   	   $	��250��6   $
��1300��6,    � 	Resources 5         LightKhakiButton �� Property �� Value��%�   &	        �� 5   
   .�5      ��  � ��$ 10 14 10 14q�6/   �� 5       � ��$
 Bold"�63   �� 5       � �� �#f2edb363   5      5      .��5      � -   5         �Name$ 
LayoutRoot��5      ���#4a756e � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      	 � ColumnDefinitions	 5   
   �� 5      $	��120 �6   �� 5      $
��1200 �6   .+�5   
   �� -   5        
 ��Name$
 
add_button��5       $��0��5!      $��0��5"      #��[  5#      $
��Left=�5$      $��0q�5%      .��6!   	Add art��5'      �� 5(       �� 
StartPoint$	 1,0&�6&    �� EndPoint$	 0,0&�67   .��5)      �  � Color$ #4a756e��6#    � Offset$ 0Q�63   � 5*      $ #f2edb3��6#   $	 0.5Q�63   5+      5-      �� 5/   
   -   5        $
 edit_button��5/      $��0��50      $��1��51      #��[  52      $
��Left=�53      $��0q�55      ��56      �� 57      $	 1,0&�6&   $	 0,0&�67   .��58      � $ #4a756e��6#   $ 0Q�63   � 59      $ #f2edb3��6#   $	 0.5Q�63   5:      .��5;   !   Edit5=      �� 5?   
   -   5        $
 delete_button��5@      $��0��5A      $��2��5B      #��[  5C      $��0q�5D      $
��Left=�5E      .��5F   "   
Delete art��5H      �� 5I      $	 1,0&�6&   $	 0,0&�67   .��5J      � $ #4a756e��6#   $ 0Q�63   � 5K      $ #f2edb3��6#   $	 0.5Q�63   5L      5N      �� 5O   
   -   5        $
 exit_button��5P      $��0��5Q      $��3��5R      $��
10,14,0,14q�5T      $
��Bold"�5U      $��50��5V      $
��Left=�5W      ���#c7cf94.��5X   "   Exit6(   �� 5Y   
   -   5        $��artlist��5Z      $��1��5[      $��4��5\      $��10q�5]      ���#f2edb3 �� View 5_      �� 5`      .P�5a      ��  �� Width$	 250��6S    �� DisplayMemberBinding 6%   ��  �� Path$ Painter�.��6_   	Painter6i   �� 5b      $	 250��6Q    6%   �� $ Title�.��6]   Title6d   �� 5c      $	 650��6W    6%   �� $ Description�.��6c   Description6p   5d      ��5f      �� 5g       �� 
TargetType" ��6   .�5h      -   5        5i       5l      ��%    5n      5p      5r      5s      