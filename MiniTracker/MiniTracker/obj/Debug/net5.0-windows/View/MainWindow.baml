   M S B A M L   `   `   `  ����F  BMiniTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MiniTracker.ViewMiniTracker.View  5   	   !    MiniTracker.View.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MiniTracker.View     5   	     � Title$  
MainWindow��5   	   $	��450��5	   	   $	��800��5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��70 �6   .+�5   
   �� $��0��6   .@�5      �� -   5         ��Name$ ViewAllTasks��5      $
��Bold"�5      $��0 0 24 0q�5      
����������	#FFD5DEEE���	#FF112AEF��5      �� *
AllItems+ �� SelectedItem 5      �� *SelectedTask+ �� View 5      �� 5      .P�5      �� $+��%Наименование задачи��6)    �� DisplayMemberBinding 5   )   ��  �� Path$ TaskName��� 5      $#��Описание задачи��6)    5   )   �� $ TaskDescription�5      5!      5"      �� 5#   
   $��1��6    �� Orientation$ 
Horizontal=�5$      $
��Left=�5%      .+�5&      �� $��10 0 5 0q�6   $��45��5'      $	��150��5(      
�������
����  �$
��18px(�5+      $
��Bold"�5,      $��Новая задача��5-      ��5.      �� *OpenAddTaskWindow+�� 5/      $��10 0 5 0q�6   $��45��50      $	��150��51      
�������
��� ���$
��18px(�54      $
��Bold"�55      $ ��Редактировать��56      ��57      �� *OpenEditTaskWindow+�� 58      $��10 0 5 0q�6   $��45��59      $	��150��5:      
�������
���  ��$
��18px(�5=      $
��Bold"�5>      $��Удалить��5?      ��5@      �� *
DeleteTask+�� 5A      $��
120 0 10 0q�6   $��45��5B      $	��150��5C      
�������
��� � �$
��18px(�5F      $
��Bold"�5G      $��Задача решена��5H      ��5I      �� *DecisionTask+5J      5K      5L      