   M S B A M L   `   `   `  ����A  =Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Cinema.Views.Admin.MovieManagementVM$Cinema.Views.Admin.MovieManagementVM  5   	   :    4Cinema.Views.Admin.MovieManagementVM.MovieManagement   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   @local2clr-namespace:Cinema.Views.Admin.MovieManagementVM   5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ MovieManagement��5
   	   $	��707��6!   $��1212  ��6.   .��5      � .+�5   
   � ���#132644$	��Top=�6$   $��70��6<   .+�5      �� $��QUẢN LÝ PHIM��6   
�������$
��16px(�6?    �� TextAlignment$ Center=�6O   $
��Bold"�6f   $��Century Gothic)�6x   $��Center=�6�   $��Center=�6�   5      � 5   
   $
��Left=�6   $	��170��6*   ���#132644.+�5      �� .+�5      � $	��100��6   
�������5      5      5      �� 5   
   -   5        $��listView��5      $��175,125,45,0q�6#    �� View 5      �� 5      .P�5      �� $��MaPhim��6%    �� Width$	 150��66    �� DisplayMemberBinding 5   $   ��  �� Path$ MaPhim��� 5      $��TenTheLoaiChinh��6%   $	 200��6>    5   %   �� $ TenTheLoaiChinh��� 5      $��TenPhim��6%   $	 280��66    5   %   �� $ TenPhim��� 5      $��	ThoiLuong��6%   $	 150��68    5    %   �� $ 	ThoiLuong��� 5!       �� CellTemplate 5"      �� 5#      .R�5$   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5%   &   �� 
���   �$	��0.5q�5&   -   	 �� CornerRadius$	 5��5'   -   
 � Cursor$

 Hand��5(   -   ��5)   *   �� 5*   .    �� 
TargetType" ��64    �� Triggers 5+   2   P� 5,   6    P� Property �@J�IsMouseOver P� Value$
 True��5-   >   . �5.   :   ��  �� Property � �� �� Value �#00e5ff5/   A   51   7   53   /   ._�55   *   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ PencilOutline=�6@   56   '   57   #   58      5:      �� 5;       5<      �� 5=      .R�5>   "   �� $ 
Horizontal=�6-   .+�5?   &   �� 
���   �$	��0.5q�5@   -   $	 5��5A   -   $

 Hand��5B   -   ��5C   *   �� 5D   .   " ��64    5E   2   P� 5F   6    �@J�IsMouseOver$
 True��5G   >   . �5H   :   ��  � �� �#ff62555I   A   5K   7   5M   /   ._�5O   *     $ DeleteOutline=�6@   5P   '   5Q   #   5R      5T      5U      5X      �� 5[   
   -   5        $��search��5[      $��Center=�6   $��0,84,0,0q�6<   $	��Top=�6N   ���	#FF3A3DB7$	��130��6}   ��5\      �� 5]      $ 
Horizontal=�6   .+�5^        $ 	SearchWeb=�6,   $��18��5_   6   $��18��5`   6   $��Center=�5a   6   $��0,0,0,0q�5b   6   �� 5c      $��Tìm kiếm��6    $��5,0,0,0q�5d   (   5e      5g      �� 5i   
   -   5        $	��add��5i      $
��Left=�6   $��
701,84,0,0q�68   $	��Top=�6L   ���	#FF3A3DB7$��92��6{   ��5j      �� 5k      $ 
Horizontal=�6   .+�5l        $ PlusCircleOutline=�6,   $��18��5m   6   $��18��5n   6   $��Center=�5o   6   $��0,0,0,0q�5p   6   �� 5q      $��Thêm��6    $��5,0,0,0q�5r   (   5s      5u      �� 5v   
   -   5        $��	keySearch��5v      $
��Left=�6#   $��
241,91,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��263��6~   5y      5z      