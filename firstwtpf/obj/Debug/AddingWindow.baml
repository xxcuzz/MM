   M S B A M L   `   `   `  ����D  @firstwtpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:firstwtpf	firstwtpf  5   	       firstwtpf.AddingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:firstwtpf     5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ AddingWindow��5
   	   $	��250��6   $	��400��6+   .��5      � ���#4a756e � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��101* �6   �� 5      $
��291* �6   .+�5   
   �� $��Right=�6   $��Center=�60   $��18��6K   $��
0,18,10,19q�6W   $��39��6k   
Painter:6�   �� 5   
   $��1��6   $��Right=�6!   $��Center=�6=   $��18��6X   $��
0,19,10,18q�6d   $��25��6x   Title:6�   �� 5   
   $��2��6   $��Right=�6!   $��Center=�6=   $��18��6X   $��
0,18,10,19q�6d   $��63��6x   Description:6�   �� 5   
   -   5         ��Name$ 
PainterBox��5      $��0��6&   $��1��63   $��Stretch=�6C   $��Center=�6a   $��18��6|   $��10,10,10,10q�6�   ���#f2edb36�   �� 5   
   -   5        $ TitleBox��5      $��1��6$   $��1��61   $��Stretch=�6A   $��Center=�6_   $��18��6z   $��10,10,10,10q�6�   ���#f2edb36�   �� 5   
   -   5        $ DescriptionBox��5      $��2��6*   $��1��67   $��Stretch=�6G   $��Center=�6e   $��18��6�   $��10,10,10,10q�6�   ���#f2edb36�   �� 5   
   -   5         ��Name$ Apply_Button��5      $��1��5      $��3��5       $��Apply��5!      ���#f2edb3$��10 10 10 10q�5#      �� 5$   
   -   5        $ Cancel_Button��5%      $��0��5&      $��3��5'      $��Cancel��5(      $��10 10 10 10q�5)      ���#c7cf945+      5-      5.      