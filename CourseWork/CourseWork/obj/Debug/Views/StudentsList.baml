   M S B A M L   `   `   `  ����E  ACourseWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseWork.ViewsCourseWork.Views  5   	   #    CourseWork.Views.StudentsList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CourseWork.Views     5   	   -   5          � Title$  CreditHistory��5   	   $	��450��6   $	��500��6,    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6    � 	Resources 5      ��%    5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��50 �6    .+�5      ��  �� CornerRadius$ 10��6   $��4��6'   $��3��68   ��5      �� 5      .��5      �  � Color$ #7BE9F6��6'    � Offset$	 0.0Q�67   � 5      $ #F083DA��6'   $ 1Q�67   5      5      �� 5      -   5        $��ThingsListBox��5      $��Center=�6+   $	��Top=�5       
������ $��0,60,0,0q�5"      y�5#      �� 	 �� ElementName$	 ThingsListBox��
 �� Path$
 Items.Count���5%      �� 5&      .R�5'      ]� ��. $��Center=�69   .+�5(      � $	��Top=�6#   $��30��68   $��Center=�6D    � ColumnDefinitions 5)   "   �� 5*   &   $	��100 �67   6E   �� 5+   &   $	��100 �67   6E   �� 5,   &   $	��100 �67   6E   �� 5-   &   $	��100 �67   6E   .+�5/   "   �� $��0��6(   .��68   	Address6A   �� 50   "   $��1��6(   .��68   Phone6?   �� 51   "   $��2��6(   .��68   	Parrent6A   �� 52   "   $��3��6(   .��68   LivingInHostel6H   53      �� 54      6/   55      56      ��58      �� 59      .R�5:      ��  �� Orientation$ 
Horizontal=�6%   $
��Left=�6>   $��0,0,0,0q�6Y   .+�5;      �� 
�������$	��100��6;   ��6G   �� *	Address+�� 5<      
�������$	��100��6;   ��6G   �� *Phone+�� 5=      
�������$	��100��6;   ��6G   �� *ParrentFullName+�� 5>      
�������$��10050��6;   ��6I   �� *LivingInHostel+5?      5@      5B      �� 5D      -   5        $��1��5D      $
��Back��6"   $��120,0,120,10q�6D   5F      5G      5H      