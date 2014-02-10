using System;
using Seasar.Extension.Tx;
using Seasar.Quill;
using Seasar.Quill.Database.DataSource.Impl;
using Seasar.Quill.Database.Tx;
using Seasar.Quill.Database.Tx.Impl;
using Seasar.Quill.Util;

namespace DfExampleTest.DBFlute
{
    /// <summary>
    /// テストフレームワークに依存せずに
    /// Quillを利用したテスト補助機能を提供するクラス
    /// </summary>
    public class QuillTestHelper
    {
        private static readonly QuillInjector _injector = QuillInjector.GetInstance();

        private static Type _defaultTransactinType = typeof (TypicalTransactionSetting);
        public  static Type DefaultTransactionType
        {
            get { return _defaultTransactinType; }
            set { _defaultTransactinType = value; }
        }

        #region static

        public static void BeginTransaction(Type transactionSettingType)
        {
            ITransactionContext context = GetTransactionContext(transactionSettingType);
            ITransactionContext current = context.Create();
            current.Parent = context.Current;
            current.Begin();
            context.Current = current;
        }

        public static void BeginTransaction(Type[] transactionSettingTypes)
        {
            foreach (Type type in transactionSettingTypes)
            {
                BeginTransaction(type);
            }
        }

        public static void BeginTransaction()
        {
            BeginTransaction(DefaultTransactionType);
        }

        public static void RollbackTransaction(Type transactionSettingType)
        {
            ITransactionContext context = GetTransactionContext(transactionSettingType);
            ITransactionContext current = context.Current;
            //  開始時点のトランザクションを辿る
            while(current != null && current.Parent != null)
            {
                current = current.Parent;
            }

            if(current != null && current.Transaction != null)
            {
                current.Rollback();
            }
        }

        public static void RollbackTransaction(Type[] transactionSettingType)
        {
            foreach (Type type in transactionSettingType)
            {
                RollbackTransaction(type);
            }
        }

        public static void RollbackTransaction()
        {
            RollbackTransaction(DefaultTransactionType);
        }

        public static void CommitTransaction(Type transactionSettingType)
        {
            GetTransactionContext(transactionSettingType).Commit();
        }

        public static void CommitTransaction(Type[] transactionSettingTypes)
        {
            foreach (Type type in transactionSettingTypes)
            {
                CommitTransaction(type);
            }
        }

        public static void CommitTransaction()
        {
            CommitTransaction(DefaultTransactionType);
        }

        private static ITransactionContext GetTransactionContext(Type transactionSettingType)
        {
            ITransactionSetting transactionSetting = (ITransactionSetting)ComponentUtil.GetComponent(
                                                                               _injector.Container,
                                                                               transactionSettingType);
            SelectableDataSourceProxyWithDictionary dataSourceProxy =
                (SelectableDataSourceProxyWithDictionary)
                ComponentUtil.GetComponent(_injector.Container, typeof(SelectableDataSourceProxyWithDictionary));
            if(!string.IsNullOrEmpty(transactionSetting.DataSourceName))
            {
                dataSourceProxy.SetDataSourceName(transactionSetting.DataSourceName);
            }
 
            if (transactionSetting.IsNeedSetup())
            {
                transactionSetting.Setup(dataSourceProxy);
            }
            return transactionSetting.TransactionContext;
        }

        public static T GetComponent<T>() where T : class 
        {
            return (T) ComponentUtil.GetComponent(_injector.Container, typeof (T));
        }

        public static void Inject(object target)
        {
            _injector.Inject(target);
        }

        /// <summary>
        /// インジェクション済のコンポーネントを取得
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetInjectedComponent<T>() where T : class
        {
            T component = GetComponent<T>();
            _injector.Inject(component);
            return component;
        }

        #endregion

        #region Instance

        public virtual void CallBeginTransaction(Type transactionSettingType)
        {
            BeginTransaction(transactionSettingType);
        }

        public virtual void CallBeginTransaction()
        {
            BeginTransaction(DefaultTransactionType);
        }

        public virtual void CallRollbackTransaction(Type transactionSettingType)
        {
            RollbackTransaction(transactionSettingType);
        }

        public virtual void CallRollbackTransaction()
        {
            RollbackTransaction(DefaultTransactionType);
        }

        public virtual void CallCommitTransaction(Type transactionSettingType)
        {
            CommitTransaction(transactionSettingType);
        }

        public virtual void CallCommitTransaction()
        {
            CommitTransaction(DefaultTransactionType);
        }

        public virtual T CallGetComponent<T>() where T : class
        {
            return GetComponent<T>();
        }

        public virtual void CallInject(object target)
        {
            Inject(target);
        }

        /// <summary>
        /// インジェクション済のコンポーネントを取得
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public virtual T CallGetInjectedComponent<T>() where T : class
        {
            return GetInjectedComponent<T>();
        }

        #endregion
    }
}
