   M S B A M L   `   `   `  ����F  BMiniTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MiniTracker.ViewMiniTracker.View  5   	   !    MiniTracker.View.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MiniTracker.View     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��70 �6   .+�5   
   �� $��0��6   .@�5      �� -   5         ��Name$ ViewAllTasks��5      $
��Bold"�5   >   $��
-24,0,24,0q�6P   
����������	#FFD5DEEE���	#FF112AEF��5   -   �� *
AllTasks+ �� SelectedItem 5      �� *SelectedTask+ �� View 5      �� 5      .P�5      �� $+��%Наименование задачи��6)    �� DisplayMemberBinding 5   )   ��  �� Path$ TaskName��� 5      $#��Описание задачи��6)    5   )   �� $ TaskDescription�5      5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�5      .+�5      �� $��45��6   $��15��6    �� 5      $��45��6   $	��150��6!   
�������
����  �$
��18px(�6R   $
��Bold"�6b   $��Новая задача��6t   ��6�   �� *OpenAddTaskWindow+�� 5      $��45��6   $��10��6    �� 5       $��45��6   $	��150��6!   
�������
��� ���$
��18px(�6S   $
��Bold"�6c   $ ��Редактировать��6u   ��6�   �� *OpenEditTaskWindow+�� 5!      $��45��6   $��10��6    �� 5"      $��45��6   $	��150��6!   
�������
���  ��$
��18px(�6Q   $
��Bold"�6a   $��Удалить��6s   ��6�   �� *
DeleteTask+�� 5#      $��45��6   $	��140��6    �� 5$      $��45��6   $	��150��6!   
�������
��� � �$
��18px(�6S   $
��Bold"�6c   $��Задача решена��6u   ��6�   �� *DecisionTask+5%      5&      5'      