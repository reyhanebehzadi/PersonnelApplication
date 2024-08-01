using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Drawing;

namespace Jamsaz.PersonnlsApplication.Classes
{
    public class MakeTree<T>
    {
        #region property Names
        public string NodeTitlePropertyName { set; get; }

        public string NodeKeyPropertyName { set; get; }

        public string NodeParentKeyPropertyName { set; get; }

        public string NodeVisualTreeNodePropertyName { set; get; }

        public string NodeIsCheckablePropertyName { set; get; }

        public string NodeColorPropertyName { get; set; }

        public string NodeCheckPropertyName { get; set; }
        #endregion

        #region Property
        public bool GetNodeIsCheckable(T nodeEntity)
        {
            PropertyInfo propertyInfo = nodeEntity.GetType().GetProperty(NodeIsCheckablePropertyName);

            bool NodeIsCheckable = false;

            if (propertyInfo != null)
            {
                NodeIsCheckable = (bool)propertyInfo.GetValue(nodeEntity, null);
            }
            else
            {
                throw new System.InvalidOperationException("MakeTree: NodeIsCheckablePropertyName not Found or the name is not correct");
            }

            return NodeIsCheckable;
        }

        public string GetNodeTitle(T nodeEntity)
        {
            PropertyInfo propertyInfo = nodeEntity.GetType().GetProperty(NodeTitlePropertyName);

            string NodeTitle = string.Empty;

            if (propertyInfo != null)
            {
                NodeTitle = propertyInfo.GetValue(nodeEntity, null).ToString();
            }
            else
            {
                throw new System.InvalidOperationException("MakeTree: NodeTitleProperty not Found or the name is not correct");
            }

            return NodeTitle;
        }

        public string GetNodeID(T nodeEntity)
        {
            PropertyInfo peropertyInfo;

            peropertyInfo = nodeEntity.GetType().GetProperty(NodeKeyPropertyName);

            string NodeID = string.Empty;

            if (peropertyInfo != null)

                NodeID = peropertyInfo.GetValue(nodeEntity, null).ToString();

            else
            {
                throw new System.InvalidOperationException("MakeTree: NodeTitleProperty not Found or the name is not correct");
            }

            return NodeID;
        }

        public string GetNodeParentID(T nodeEntity)
        {
            PropertyInfo propertyInfo = nodeEntity.GetType().GetProperty(NodeParentKeyPropertyName);

            string NodeParentID = string.Empty;

            if (propertyInfo != null)
            {
                try
                {
                    NodeParentID = propertyInfo.GetValue(nodeEntity, null).ToString();
                }
                catch (Exception ex)
                {
                    return "";
                }
            }
            else
            {
                throw new System.InvalidOperationException("MakeTree: NodeTitleProperty not Found or the name is not correct");
            }

            return NodeParentID;
        }

        public Color GetNodeColor(T nodeEntity)
        {
            PropertyInfo propertyInfo = nodeEntity.GetType().GetProperty(NodeColorPropertyName);

            Color ValueColor = Color.Empty;

            if (propertyInfo != null)
            {
                try
                {
                    ValueColor = (Color)propertyInfo.GetValue(nodeEntity, null);
                }
                catch
                {
                    return Color.Empty;
                }
            }
            else
            {
                throw new System.InvalidOperationException("MakeTree: NodeTitleProperty not Found or the name is not correct");
            }

            return ValueColor;
        }

        public bool GetNodeChecked(T nodeEntity)
        {
            //PropertyInfo propertyInfo = nodeEntity.GetType().GetProperty(NodeCheckPropertyName);

            //bool NodeValueChecket = false;

            //if (propertyInfo != null)
            //{

            //    NodeValueChecket = (bool)propertyInfo.GetValue(nodeEntity, null);
            //}
            //else
            //{
            //    throw new System.InvalidOperationException("MakeTree: NodeCheckPropertyName not Found or the name is not correct");
            //}

            //return NodeValueChecket;
            return  false;
        }

        public void SetNodeChecked(T nodeEntity, bool value)
        {
            PropertyInfo propertyInfo = nodeEntity.GetType().GetProperty(NodeCheckPropertyName);

            if (propertyInfo != null)
            {
                propertyInfo.SetValue(nodeEntity, value, null);
            }
            else
            {
                throw new System.InvalidOperationException("MakeTree: NodeCheckPropertyName not Found or the name is not correct");
            }


        }

        public T currentNode;

        private void setVisualTreeNodeProperty(T nodeEntity, TreeNode visualTreeNode)
        {
            if (NodeVisualTreeNodePropertyName != null && NodeVisualTreeNodePropertyName != string.Empty)
            {
                PropertyInfo propertyInfo = nodeEntity.GetType().GetProperty(NodeVisualTreeNodePropertyName);

                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(nodeEntity, visualTreeNode, null);
                }
                else
                {
                    throw new System.InvalidOperationException("MakeTree: NodeVisualTreeNodePropertyName not Found or the name is not correct");
                }
            }
        }
   
        #endregion
        IEnumerable<T> sourceTable;
        public void CreateChartTree(T RootNode, IEnumerable<T> sourceTable, TreeView treeView, T selectedNode)
        {
            treeView.BeforeCheck += new TreeViewCancelEventHandler(treeView_BeforeCheck);
            treeView.AfterCheck += new TreeViewEventHandler(treeView_AfterCheck);
            
            this.sourceTable = sourceTable;
            currentNode = selectedNode;

            TreeNode node = new TreeNode(GetNodeTitle(RootNode));
          
            setVisualTreeNodeProperty(RootNode, node);

            node.Tag = RootNode;
            
            node.Checked = GetNodeChecked(RootNode);
        
            treeView.Nodes.Add(node);
            
            if (currentNode != null)

                if (GetNodeID(RootNode) == GetNodeID(currentNode))

                    treeView.SelectedNode = node;
         

            foreach (T item in sourceTable)
            {
                if (GetNodeParentID(item) != null)
                    if (GetNodeParentID(item) == GetNodeID(RootNode))
                    {
                        MakeNodes(item, treeView, node);
                    }
            }
            node.ImageIndex = 7;
        }

        private void MakeNodes(T Item, TreeView treeView, TreeNode tnNode)
        {
            try
            {
                TreeNode tnRoot = new TreeNode(GetNodeTitle(Item));
                tnRoot.Tag = Item;
                tnRoot.Checked = GetNodeChecked(Item);
                tnNode.Nodes.Add(tnRoot);
                if (currentNode != null)
                {
                    if (GetNodeID(currentNode) == GetNodeID(Item))
                    {
                        treeView.SelectedNode = tnRoot;

                    }
                    foreach (T item in this.sourceTable)
                        if (GetNodeParentID(item) != null)
                            if (GetNodeParentID(item) == GetNodeID(Item))
                            { 
                                MakeNodes(item,treeView, tnRoot);
                            }
                    

                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }


        private void FindNode(T sourceItem, IEnumerable<T> sourceTable, int valueNodeID)
        {
            foreach (T item in sourceTable)
            {
                if (GetNodeParentID(item) != null)

                    if (GetNodeParentID(item) == GetNodeID(sourceItem))
                    {
                        if (GetNodeID(item) == valueNodeID.ToString())
                        {
                            IsFindeNode = true;
                            return;
                        }
                        else
                            IsFindeNode = false;

                        FindNode(item, sourceTable, valueNodeID);
                    }
            }
        }

        public void FindNodeDetail(T sourceItem, IEnumerable<T> sourceTable,  int valueNodeID)
        {
            try
            {
                    foreach (T item in sourceTable)
                        if (GetNodeParentID(item) != null)
                            if (GetNodeParentID(item) == GetNodeID(sourceItem))
                            {
                                if (GetNodeID(item) == valueNodeID.ToString())
                                {
                                    IsFindeNode = true;
                                    return;
                                }
                                else IsFindeNode = false;
                         
                                    
                                FindNodeDetail(item, sourceTable, valueNodeID);
                            }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        public bool IsFindeNode { get; set; }

        void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            this.SetNodeChecked((T)e.Node.Tag, e.Node.Checked);
        }

        void treeView_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (NodeIsCheckablePropertyName != null && NodeIsCheckablePropertyName != string.Empty)
            {
                if (!this.GetNodeIsCheckable((T)e.Node.Tag))
                    
                    e.Cancel = true;
            }
        }
    }
}
