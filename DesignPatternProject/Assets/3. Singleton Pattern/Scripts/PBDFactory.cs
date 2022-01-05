using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class PBDFactory :IAssetFactory
    {
        private static IAssetFactory m_AssetFactory = null;
        private static bool m_bLoadFromResource;

        /// <summary>
        /// 取得將Unity Asset實作化的工廠
        /// </summary>
        public static IAssetFactory GetAssetFactory()
        {
            if(m_AssetFactory == null)
            {
                if (m_bLoadFromResource)
                {
                    m_AssetFactory = new ResourceAssetFactory();
                }
                else
                {
                    m_AssetFactory = new RemoteAssetFactory();
                }
            }
            return m_AssetFactory;
        }
    }

    public class ResourceAssetFactory:IAssetFactory
    {

    }
    public class RemoteAssetFactory : IAssetFactory
    {

    }
}